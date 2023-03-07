using AdminKB.Dominio.Modelos;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class ContaBancariaApp : AppBase<ContaBancaria>
    {
        public ContaBancariaApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new ContaBancaria()
            {
                BancoId = new BancoApp().BuscaTipoEntidadePadrao().BancoId,
                Iban = "Desconhecido",
                Natureza = "Desconhecido",
                Numero = "Desconhecido",
                Sequencia = "Desconhecido",
                Swift = "Desconhecido"
            });
            Adicionar(new ContaBancaria()
            {
                BancoId = new BancoApp().BuscaTodosRegistros()[3].BancoId,
                Iban = "15972959610001",
                Natureza = "15972959610001",
                Numero = "15972959610001",
                Sequencia = "15972959610001",
                Swift = "15972959610001"
            });
            base.InicializaTabela();
        }

        public ContaBancaria RetornContaBancariaPadrao()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<ContaBancaria>().
                Include(cb => cb.Banco)
                .FirstOrDefault();
        }
    }
}
