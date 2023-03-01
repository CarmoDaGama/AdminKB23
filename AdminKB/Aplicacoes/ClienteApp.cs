using Dominio.Modelos;
using Dominio.Utilitarios;

namespace AdminKB.Aplicacoes
{
    public class ClienteApp : AppBase<Client>
    {
        public ClienteApp() : base(true)
        {
        }
        protected override void InicializaTabela()
        {
            Adicionar(new Client()
            {
                Name = Globais.ClientePadrao,
                Nif = "999999999",
            });
            base.InicializaTabela();
        }
    }
}
