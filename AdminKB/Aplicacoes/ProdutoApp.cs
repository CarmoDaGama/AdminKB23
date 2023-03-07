using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Modelos;
using System;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class ProdutoApp : AppBase<Produto>
    {
        public ProdutoApp():base(true)
        {

        }
        public Produto BuscaProdutoPorId(int produtoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Produto>()
                           .Include(p => p.Categoria)
                           .Include(p => p.Imposto)
                           .Include(p => p.MotivoIsencao)
                           .Where( p => p.ProdutoId == produtoId)
                           .FirstOrDefault();
        }
        public new int Adicionar(Produto produto)
        {
            base.Adicionar(produto);
            return BuscaUltimaTipoEntidade().ProdutoId;
        }

        public bool CodigoDeBarraExistente(string codigoDeBarra)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Produto>().Where(p => p.CodigoDeBarra == codigoDeBarra).FirstOrDefault() != null;
        }
        public new void Remover(Produto produto)
        {
            produto.Estado = EstadoEntidade.Desactivo;
            Actualizar(produto);
        }
        public void Remover(int produtoId)
        {
            var produto = BuscaProdutoPorId(produtoId);
            produto.Estado = EstadoEntidade.Desactivo;
            Actualizar(produto);
        }
        protected override void InicializaTabela()
        {
            Adicionar(new Produto()
            {
                Nome = "Banana", CategoriaId = 1,
                CodigoDeBarra="01", 
                Estado = EstadoEntidade.Activo, 
                ControleEstoque = true, 
                ImpostoId = 2, MotivoIsencaoId = 1, 
                Preco=150, 
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Goiaba",
                CategoriaId = 1,
                CodigoDeBarra = "02",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 100,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Hananas",
                CategoriaId = 1,
                CodigoDeBarra = "03",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 1000,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Maboque",
                CategoriaId = 1,
                CodigoDeBarra = "04",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 200,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Morango",
                CategoriaId = 1,
                CodigoDeBarra = "05",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 2000,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Maçã",
                CategoriaId = 1,
                CodigoDeBarra = "06",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 200,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Maracuja",
                CategoriaId = 1,
                CodigoDeBarra = "07",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 250,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Guarana",
                CategoriaId = 1,
                CodigoDeBarra = "08",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 600,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Batata",
                CategoriaId = 1,
                CodigoDeBarra = "09",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 50,
                Vender = true
            });
            Adicionar(new Produto()
            {
                Nome = "Abacaxis",
                CategoriaId = 1,
                CodigoDeBarra = "10",
                Estado = EstadoEntidade.Activo,
                ControleEstoque = true,
                ImpostoId = 2,
                MotivoIsencaoId = 1,
                Preco = 500,
                Vender = true
            });
            base.InicializaTabela();
        }

        public Produto RetornaProdutoPorId(int produtoId)
        {

            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                return contexto.Set<Produto>()
                               .Include(p => p.Categoria)
                               .Include(p => p.Imposto)
                               .Include(p => p.MotivoIsencao)
                               .Where(p => p.ProdutoId == produtoId)
                               .FirstOrDefault();
            }
        }
    }
}
