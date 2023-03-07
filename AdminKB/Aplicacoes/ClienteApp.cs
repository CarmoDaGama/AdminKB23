using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;

namespace AdminKB.Aplicacoes
{
    public class ClienteApp : AppBase<Cliente>
    {
        public ClienteApp() : base(true)
        {
        }
        protected override void InicializaTabela()
        {
            Adicionar(new Cliente()
            {
                Nome = Globais.ClientePadrao,
                Nif = "999999999",
            });
            base.InicializaTabela();
        }
    }
}
