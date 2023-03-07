using AdminKB.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Utilitarios;

namespace AdminKB.Aplicacoes
{
    public class ProdutoEstoqueApp : AppBase<ProdutoEstoque>
    {
        public ProdutoEstoqueApp():base(true)
        {

        }

        public List<ProdutoEstoque> CarregarProdutos()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) {
                var produtosRetornar = new List<ProdutoEstoque>();
                var produtosEstoque = contexto.Set<ProdutoEstoque>()
                               .Include(p => p.Estoque)
                               .Include(p => p.Produto)
                               .Include(p => p.Produto.Categoria)
                               .Include(p => p.Produto.Imposto)
                               .Include(p => p.Produto.MotivoIsencao)
                               .Where(p => p.Produto.Estado == EstadoEntidade.Activo)
                               .ToList();


                foreach (var item in produtosEstoque)
                {
                    if (Util.ListaNula(produtosRetornar))
                    {
                        produtosRetornar = new List<ProdutoEstoque>() { item };
                    }
                    else
                    {
                        var produtoResult = produtosRetornar.Where(p => p.ProdutoId == item.ProdutoId).FirstOrDefault();
                        if (Util.ObjectoNulo(produtoResult))
                        {
                            produtosRetornar.Add(item);
                        }
                        else
                        {
                            produtoResult.Quantidade += item.Quantidade;
                            item.Estoque.Nome = item.Estoque.Nome.Replace("; " + produtoResult.Estoque.Nome, string.Empty);
                            produtoResult.Estoque.Nome += "; " + item.Estoque.Nome; 
                        }
                    }
                }

                return produtosRetornar;
            }
        }

        public List<ProdutoEstoque> CarregarProdutosVendaPorEstoqueId(int estoqueId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoEstoque>()
                              .Include(p => p.Estoque)
                              .Include(p => p.Produto)
                              .Include(p => p.Produto.Categoria)
                              .Include(p => p.Produto.Imposto)
                              .Include(p => p.Produto.MotivoIsencao)
                              .Where(p => (p.Estado == EstadoEntidade.Activo &&
                                           p.Produto.Estado == EstadoEntidade.Activo) &&
                                           p.Produto.Vender && 
                                           p.Estoque.EstoqueId == estoqueId)
                              .ToList();
        }

        public List<ProdutoEstoque> CarregarProdutosVenda()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoEstoque>()
                           .Include(p => p.Estoque)
                           .Include(p => p.Produto)
                           .Include(p => p.Produto.Categoria)
                           .Include(p => p.Produto.Imposto)
                           .Include(p => p.Produto.MotivoIsencao)
                           .Where(p => (p.Estado == EstadoEntidade.Activo && p.Produto.Estado == EstadoEntidade.Activo) && p.Produto.Vender)
                           .ToList();
        }

        public ProdutoEstoque RetornaProdutoPorCodigoDeBarra(string codigoDeBarra)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoEstoque>()
                        .Include(p => p.Estoque)
                        .Include(p => p.Produto)
                        .Include(p => p.Produto.Categoria)
                        .Include(p => p.Produto.Imposto)
                        .Include(p => p.Produto.MotivoIsencao)
                        .Where(p => (p.Estado == EstadoEntidade.Activo &&
                                     p.Produto.Estado == EstadoEntidade.Activo) &&
                                     p.Produto.Vender && p.Produto.CodigoDeBarra == codigoDeBarra)
                        .FirstOrDefault();
        }

        public List<ProdutoEstoque> CarregarProdutosPorId(int produtoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoEstoque>()
                              .Include(p => p.Estoque)
                              .Include(p => p.Produto)
                              .Include(p => p.Produto.Categoria)
                              .Include(p => p.Produto.Imposto)
                              .Include(p => p.Produto.MotivoIsencao)
                              .Where(p => p.Estado == EstadoEntidade.Activo && p.ProdutoId == produtoId)
                              .ToList();
        }

        public bool ExisteLoteDeste(string numeroSerie)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoEstoque>().Where(p => p.NumeroDeSerie == numeroSerie).FirstOrDefault() != null;
        }

        public void GravarProdutosEstoque(Produto produto, List<ProdutoEstoque> listaProdutoEstoque)
        {
            foreach (var item in listaProdutoEstoque)
            {
                if (item.ProdutoEstoqueId <= 0)
                {
                    item.ProdutoId = produto.ProdutoId;
                    item.DataDeRegistro = DateTime.Now;
                    Adicionar(item);
                }
                else
                {
                    Actualizar(item);
                }
            }
        }

        public void RemoverPorNumeroDeSerie(string numeroDeSerie)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var produtoEstoque =  contexto.Set<ProdutoEstoque>()
                                          .Include(p => p.Estoque)
                                          .Include(p => p.Produto)
                                          .Include(p => p.Produto.Categoria)
                                          .Include(p => p.Produto.Imposto)
                                          .Include(p => p.Produto.MotivoIsencao)
                                          .Where(p => p.Estado == EstadoEntidade.Activo && p.NumeroDeSerie == numeroDeSerie)
                                          .FirstOrDefault();
                Remover(produtoEstoque);
            }
        }
        public new void Remover(ProdutoEstoque produtoEstoque)
        {
            if (!Util.ObjectoNulo(produtoEstoque))
            {
                produtoEstoque.Estado = EstadoEntidade.Desactivo;
                Actualizar(produtoEstoque);
            }
        }
        public new void Actualizar(ProdutoEstoque produtoEstoque)
        {
            base.Actualizar(produtoEstoque);
            produtoEstoque.Produto = new ProdutoApp().RetornaProdutoPorId(produtoEstoque.ProdutoId);
            produtoEstoque.Estoque = new EstoqueApp().BuscaPorId(produtoEstoque.EstoqueId);
        }
        public ProdutoEstoque CarregarProdutosDisponivel(int produtoComponenteId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var produtoEstoque = contexto.Set<ProdutoEstoque>()
                                             .Include(p => p.Estoque)
                                             .Include(p => p.Produto)
                                             .Include(p => p.Produto.Categoria)
                                             .Include(p => p.Produto.Imposto)
                                             .Include(p => p.Produto.MotivoIsencao)
                                             .Where(p => p.Estado == EstadoEntidade.Activo && 
                                                         p.Produto.Estado == EstadoEntidade.Activo && 
                                                         p.Produto.ProdutoId == produtoComponenteId &&
                                                         p.Quantidade - p.QuantidadeMinima > 0)
                                             .FirstOrDefault();
                return produtoEstoque;
            }
        }

        public ProdutoEstoque RetornaProdutoPorId(int produtoEstoqueId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ProdutoEstoque>()
                           .Include(p => p.Estoque)
                           .Include(p => p.Produto)
                           .Include(p => p.Produto.Categoria)
                           .Include(p => p.Produto.Imposto)
                           .Include(p => p.Produto.MotivoIsencao)
                           .Where(p => (p.Estado == EstadoEntidade.Activo &&
                                        p.Produto.Estado == EstadoEntidade.Activo) &&
                                        p.Produto.Vender && p.ProdutoEstoqueId == produtoEstoqueId)
                           .FirstOrDefault();
        }
        protected override void InicializaTabela()
        {
            var produtos = new ProdutoApp().BuscaTodosRegistros();

            Adicionar(new ProdutoEstoque()
            {
                 DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now, 
                Estado = EstadoEntidade.Activo, 
                EstoqueId = 1, 
                NumeroDeSerie="001",
                ProdutoId = produtos[0].ProdutoId,
                Quantidade = 40, 
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "002",
                ProdutoId = produtos[1].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "003",
                ProdutoId = produtos[2].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "004",
                ProdutoId = produtos[3].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "005",
                ProdutoId = produtos[4].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "006",
                ProdutoId = produtos[5].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "007",
                ProdutoId = produtos[6].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "008",
                ProdutoId = produtos[7].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "009",
                ProdutoId = produtos[8].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            Adicionar(new ProdutoEstoque()
            {
                DataDeFabricacao = DateTime.Now,
                DataDeExpiracao = Util.RetornaDataVencime(30),
                DataDeRegistro = DateTime.Now,
                Estado = EstadoEntidade.Activo,
                EstoqueId = 1,
                NumeroDeSerie = "010",
                ProdutoId = produtos[9].ProdutoId,
                Quantidade = 40,
                QuantidadeMaxima = 100,
                UmLote = true

            });
            base.InicializaTabela();
        }
    }
}
