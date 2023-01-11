using Dominio.Modelos;
using Dominio.Modelos.ModulosVer;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class ProdutoComponenteApp : AppBase<ProdutoComposicao>
    {
        public ProdutoComponenteApp():base(true)
        {

        }
        public new void Adicionar(ProdutoComposicao produtoComponente)
        {
            var produto = produtoComponente.Produto;
            //var produtoEstoque = produtoComponente.ProdutoCompenente;
            produtoComponente.Produto = null;
            //produtoComponente.ProdutoCompenente = null;
            base.Adicionar(produtoComponente);
            produtoComponente.Produto = produto;
            //produtoComponente.ProdutoCompenente = produtoEstoque;
        }
        public void AdicionarVer(ProdutoComposicaoVer produtoComponente)
        {
            base.Adicionar(new ProdutoComposicao()
            {
                Produto = produtoComponente.Produto,
                DataDeRegistro = produtoComponente.DataDeRegistro,
                ProdutoComposicaoId = produtoComponente.ProdutoComposicaoId,
                ProdutoComponenteId = produtoComponente.ProdutoComponenteId,
                ProdutoId = produtoComponente.ProdutoId,
                Quantidade = produtoComponente.Quantidade
            });
        }
        public void Actualizar(ProdutoComposicaoVer produtoComposicao)
        {
            Actualizar(new ProdutoComposicao()
            {
                Produto = produtoComposicao.Produto,
                DataDeRegistro = produtoComposicao.DataDeRegistro,
                ProdutoComposicaoId = produtoComposicao.ProdutoComposicaoId,
                ProdutoComponenteId = produtoComposicao.ProdutoComponenteId,
                ProdutoId = produtoComposicao.ProdutoId,
                Quantidade = produtoComposicao.Quantidade
            });
        }
        public List<ProdutoComposicao> CarregarProdutosCompPorId(int produtoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoComposicao>()
                           .Include(p => p.Produto)
                           //.Include(p => p.ProdutoCompenente)
                           .Where(p => p.ProdutoId == produtoId)
                           .ToList();
        }
        public List<ProdutoComposicaoVer> CarregarProdutosCompVerPorId(int produtoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var composicao = contexto.Set<ProdutoComposicao>()
                           .Include(p => p.Produto)
                           //.Include(p => p.ProdutoCompenente)
                           .Where(p => p.ProdutoId == produtoId)
                           .ToList();

                var composicaoVer = new List<ProdutoComposicaoVer>();
                var _parodutoApp = new ProdutoApp();
                foreach (var item in composicao)
                {
                    composicaoVer.Add(new ProdutoComposicaoVer()
                    {
                        ProdutoId = item.ProdutoId,
                        DataDeRegistro = item.DataDeRegistro, 
                        Produto = item.Produto, 
                        ProdutoComponente = _parodutoApp.BuscaProdutoPorId(item.ProdutoComponenteId),
                        ProdutoComponenteId = item.ProdutoComponenteId, 
                        ProdutoComposicaoId = item.ProdutoComposicaoId,
                        Quantidade = item.Quantidade
                    });
                }
                return composicaoVer;
            }
        }

        public void GravarProdutosComp(Produto produto, List<ProdutoComposicaoVer> listaProdutoComponentes)
        {
            if (!Util.ListaNula(listaProdutoComponentes))
            {
                var _produtoApp = new ProdutoApp();
                foreach (var item in listaProdutoComponentes)
                {
                    if (item.ProdutoComposicaoId <= 0)
                    {
                        item.ProdutoComponente = _produtoApp.BuscaProdutoPorId(item.ProdutoComponenteId);
                        item.ProdutoId = produto.ProdutoId;
                        item.DataDeRegistro = DateTime.Now;
                        Adicionar(new ProdutoComposicao()
                        {
                            Produto = item.Produto,
                            DataDeRegistro = item.DataDeRegistro,
                            ProdutoComposicaoId = item.ProdutoComposicaoId,
                            ProdutoComponenteId = item.ProdutoComponenteId,
                            ProdutoId = item.ProdutoId,
                            Quantidade = item.Quantidade
                        });
                    }
                    else
                    {

                        Actualizar(new ProdutoComposicao() { 
                            Produto = item.Produto,
                            DataDeRegistro = item.DataDeRegistro,
                            ProdutoComposicaoId = item.ProdutoComposicaoId,
                            ProdutoComponenteId = item.ProdutoComponenteId,
                            ProdutoId = item.ProdutoId, 
                            Quantidade = item.Quantidade
                        });
                    }
                }
            }
        }

        public void RemoverVer(ProdutoComposicaoVer produtoComposicao)
        {
            Remover(new ProdutoComposicao()
            {
                 DataDeRegistro = produtoComposicao.DataDeRegistro, 
                Produto = produtoComposicao.Produto,
                ProdutoComponenteId = produtoComposicao.ProdutoComponenteId,
                ProdutoComposicaoId = produtoComposicao.ProdutoComposicaoId, 
                ProdutoId = produtoComposicao.ProdutoId, 
                Quantidade = produtoComposicao.Quantidade
            });
        }

        public List<ProdutoComposicao> RetornaProdutosCompsPorProdutoId(int produtoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<ProdutoComposicao>()
                           .Where(pc => pc.ProdutoId == produtoId)
                           .ToList();
        }
    }
}
