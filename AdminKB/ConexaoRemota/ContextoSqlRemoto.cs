using Dominio.Modelos;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConexaoRemota
{
    public class ContextoSqlRemoto : DbContext
    {
        public ContextoSqlRemoto(string stringConnection) : base(stringConnection)
        {
            //Database.CurrentTransaction.
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Conexao> Conexoes { get; set; }
        public DbSet<Acesso> Acessos { get; set; }
        public DbSet<Licenca> Licensas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<TipoImposto> TipoImpostos { get; set; }
        public DbSet<Imposto> Impostos { get; set; }
        public DbSet<MotivoIsencao> MotivoIsencoes { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoEstoque> ProdutoEstoques { get; set; }
        public DbSet<ProdutoComposicao> ProdutoComponentes { get; set; }
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<Turno> Turnos { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ProdutoMovimentacao> ProdutoMovimentacoes { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<DocumentoAnulado> DocumentoAnulados { get; set; }
        public DbSet<Banco> Bancos { get; set; }
        public DbSet<ContaBancaria> ContaBancarias { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbSet<FormaPaga> FormaPagas { get; set; }
        public DbSet<Saft> Safts { get; set; }
    }
}
