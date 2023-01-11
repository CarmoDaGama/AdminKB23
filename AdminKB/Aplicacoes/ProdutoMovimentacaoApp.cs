using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Dominio.Enumerados;
using Dominio.Utilitarios;

namespace AdminKB.Aplicacoes
{
    public class ProdutoMovimentacaoApp : AppBase<ProdutoMovimentacao>
    {
        private ProdutoEstoqueApp _ProdutoEstiqueApp;

        public ProdutoMovimentacaoApp() : base(true)
        {

            _ProdutoEstiqueApp = new ProdutoEstoqueApp();
        }

        public ProdutoMovimentacao CriarProdutoMovimentacao(int documentoId, int produtoEstoqueId, decimal quantidade)
        {
            var documento = new DocumentoApp().RetornaDocumentoPorId(documentoId);
            var produtoEstoque = new ProdutoEstoqueApp().RetornaProdutoPorId(produtoEstoqueId);

            var impostoMov = Util.CalculaRetornaValorPercentual(produtoEstoque.Produto.Preco, produtoEstoque.Produto.Imposto.Percentagem);
            var retencaoMov = Util.CalculaRetornaValorPercentual(produtoEstoque.Produto.Preco, produtoEstoque.Produto.Retencao);
            var descontoGlobalMov = Util.CalculaRetornaValorPercentual(produtoEstoque.Produto.Preco, documento.DescontoGlobal);
            Adicionar(new ProdutoMovimentacao
            {
                DocumentoId = documento.DocumentoId,
                Imposto = impostoMov * quantidade,
                Preco = produtoEstoque.Produto.Preco,
                ProdutoEstoqueId = produtoEstoque.ProdutoEstoqueId,
                Quantidade = quantidade,
                Retencao = produtoEstoque.Produto.Retencao,
                TotaIliquido = (produtoEstoque.Produto.Preco - descontoGlobalMov) * quantidade,
                Total = (produtoEstoque.Produto.Preco + impostoMov + retencaoMov) * quantidade, 
                Desconto = descontoGlobalMov * quantidade,

            });
            return RetornaProdutoMovimentaoPorId(BuscaUltimaTipoEntidade().ProdutoMovimentacaoId);
        }

        public ProdutoMovimentacao RetornaProdutoMovimentaoPorId(int produtoMovimentacaoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoMovimentacao>()
                           .Include(pm => pm.Documento)
                           .Include(pm => pm.ProdutoEstoque)
                           .Include(pm => pm.ProdutoEstoque.Produto)
                           .Include(pm => pm.ProdutoEstoque.Produto.Imposto)
                           .Include(pm => pm.ProdutoEstoque.Produto.MotivoIsencao)
                           .Where(pm => pm.ProdutoMovimentacaoId == produtoMovimentacaoId)
                           .FirstOrDefault();
        }

        public List<ProdutoMovimentacao> RetornaProdutosMovPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoMovimentacao>()
                           .Include(pm => pm.Documento)
                           .Include(pm => pm.Documento.Tipo)
                           .Include(pm => pm.ProdutoEstoque)
                           .Include(pm => pm.ProdutoEstoque.Produto)
                           .Include(pm => pm.ProdutoEstoque.Produto.Imposto)
                           .Include(pm => pm.ProdutoEstoque.Produto.Imposto.TipoImposto)
                           .Include(pm => pm.ProdutoEstoque.Produto.MotivoIsencao)
                           .Where(pm => pm.DocumentoId == documentoId)
                           .ToList();
        }

        public List<ProdutoMovimentacao> RetornaProdutosMovPorTurnoId(int turnoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoMovimentacao>()
                           .Include(pm => pm.Documento)
                           .Include(pm => pm.Documento.Tipo)
                           .Include(pm => pm.ProdutoEstoque)
                           .Include(pm => pm.ProdutoEstoque.Produto)
                           .Include(pm => pm.ProdutoEstoque.Produto.Imposto)
                           .Include(pm => pm.ProdutoEstoque.Produto.MotivoIsencao)
                           .Where(pm => pm.Documento.TurnoId == turnoId &&
                                        pm.Documento.Tipo.Financeiro != MovFinanceiro.Isento &&
                                        pm.Documento.Estado == EstadoDocumento.Fechado)
                           .ToList();
        }

        internal object RetornaProdutosMovPorFin(MovFinanceiro financeiro)
        {
            throw new NotImplementedException();
        }

        public decimal RetornaLocroProdutosPorDocumentoId(int documentoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var artigoMovs = contexto.Set<ProdutoMovimentacao>()
                               .Include(a => a.ProdutoEstoque)
                               .Include(a => a.ProdutoEstoque.Produto)
                               .Include(a => a.ProdutoEstoque.Produto.Imposto)
                               .Include(a => a.ProdutoEstoque.Produto.Imposto.TipoImposto)
                               .Include(a => a.ProdutoEstoque.Produto.MotivoIsencao)
                               .Include(a => a.ProdutoEstoque.Produto.Categoria)
                               .Include(a => a.Documento)
                               .Include(a => a.Documento.Cliente)
                               .Include(a => a.Documento.Tipo)
                               .Where(a => a.DocumentoId == documentoId)
                               .OrderBy(a => a.ProdutoMovimentacaoId).ToList();

                return artigoMovs.Sum(a => a.Total - a.ProdutoEstoque.Produto.Custo * a.Quantidade);
            }
        }

        public void DevolverTodosProdutosMovimentacao(int documentoId)
        {
            var produtosMovimentar = RetornaProdutosMovPorDocumentoId(documentoId);
            foreach (var artigo in produtosMovimentar)
            {
                DevolverArtigoInListMov(artigo);
            }
            //ArtigosMovimentar.Clear();
        }
        private void DevolverArtigoInListMov(ProdutoMovimentacao produtoMovDevolver)
        {
            var artigoInvNoMov = new ProdutoEstoqueApp().RetornaProdutoPorId(produtoMovDevolver.ProdutoEstoqueId);
            UpdateQtdArtigo(artigoInvNoMov, -1 * produtoMovDevolver.Quantidade, produtoMovDevolver.Documento.Tipo.Estoque);
            UpdateQtdArtigoComps(artigoInvNoMov, -1 * produtoMovDevolver.Quantidade, produtoMovDevolver.Documento.Tipo.Estoque);
        }
        private void UpdateQtdArtigoComps(ProdutoEstoque produtoEstoque, decimal qtd, MovEstoque movInv)
        {
            if (movInv == MovEstoque.Debita)
            {
                var artigoComps =new ProdutoComponenteApp().RetornaProdutosCompsPorProdutoId(produtoEstoque.ProdutoId);
                foreach (var comp in artigoComps)
                {
                    var artigoInvNaComposicao = _ProdutoEstiqueApp.CarregarProdutosDisponivel(comp.ProdutoComponenteId);
                    artigoInvNaComposicao.Quantidade -= qtd * comp.Quantidade;
                    _ProdutoEstiqueApp.Actualizar(artigoInvNaComposicao);
                }
            }
        }

        private void UpdateQtdArtigo(ProdutoEstoque produtoEstoque, decimal qtd, MovEstoque movInv)
        {
            if (movInv == MovEstoque.Debita)
            {
                produtoEstoque.Quantidade -= qtd;
                _ProdutoEstiqueApp.Actualizar(produtoEstoque);
            }
        }

        public void DevolverArtigoMovsSaida(int documentoId)
        {
            var artigosMovimentar = RetornaProdutosMovPorDocumentoId(documentoId);
            foreach (var produtoMov in artigosMovimentar)
            {
                var artigoInvNoMov = new ProdutoEstoqueApp().RetornaProdutoPorId(produtoMov.ProdutoEstoqueId);
                UpdateQtdArtigo(artigoInvNoMov, -1 * produtoMov.Quantidade, produtoMov.Documento.Tipo.Estoque);
            }
            //ArtigosMovimentar.Clear();
        }
        public void DevolverArtigoMovsEntrada(int documentoId)
        {
            var artigosMovimentar = RetornaProdutosMovPorDocumentoId(documentoId);
            foreach (var artigo in artigosMovimentar)
            {
                var artigoInvNoMov = new ProdutoEstoqueApp().RetornaProdutoPorId(artigo.ProdutoEstoqueId);
                UpdateQtdArtigo(artigoInvNoMov, artigo.Quantidade, artigo.Documento.Tipo.Estoque);
            }
            //ArtigosMovimentar.Clear();
        }
    }
}
