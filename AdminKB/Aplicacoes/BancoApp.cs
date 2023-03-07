using AdminKB.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class BancoApp : AppBase<Banco>
    {
        public BancoApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            foreach (string nomeBanco in RetornaVectorBancos())
            {
                Adicionar(new Banco
                {
                    Nome = nomeBanco
                });
            }
            base.InicializaTabela();
        }
        private string[] RetornaVectorBancos()
        {
            return new string[]  {
                "DESCONHECIDO",
                "BANCO DE POUPANCA E CREDITO (BPC)",
                "BANCO DE FOMENTO ANGOLA (BFA)",
                "BANCO ESPIRITO SANTOS (BESA)",
                "BANCO AFRICANO DE INVESTIMENTO (BAI)",
                "BANCO ANGOLANO DE NEGOCIOS E COMERCIO (BANC)",
                "BANCO BAI MICRO FINANCAS (BMF)",
                "BANCO BIC (BIC)",
                "BANCO CAIXA GERAL TOTA DE ANGOLA (BCGTA)",
                "BANCO DE INVESTIMENTO RURAL (BIR)",
                "Banco Comercial Angolano (BCA)",
                "Banco de Comércio e Indústria (BCI)",
                "Banco de Negocios Internacional (BNI)",
                "Banco Millennium Angola (BMA)",
                "Banco Regional do Keve (BRK)",
                "Banco Privado Atlantico (BPA)",
                "Banco Sol (BSOL)",
                "Finibanco Angola (FNB)",
                "Standard Bank de Angola (SCBA)"
            };

        }
    }
}
