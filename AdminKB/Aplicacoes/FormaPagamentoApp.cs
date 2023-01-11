using Dominio.Modelos;
using Dominio.Modelos.ModulosVer;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class FormaPagamentoApp : AppBase<FormaPagamento>
    {
        public FormaPagamentoApp():base(true)
        {
        }
        public List<FormaPagaVer> RetornaFormasPagaVer()
        {
            return MapeamentoCostumizado<FormaPagamento, FormaPagaVer>.Map(BuscaTodosRegistros());
        }
        protected override void InicializaTabela()
        {
            Adicionar(new FormaPagamento()
            {
                Banco = "Inexistente",
                IBAN = "Inexistente",
                Numero = "Inexistente",
                Descricao = Globais.MetodoPagamentoPadrao
            });
            Adicionar(new FormaPagamento()
            {
                Banco="BAI",
                IBAN="0040.0000.8967.4300.700076", 
                Numero="12345678902",
                Descricao = "Transferência Bancaria Padrão"
            });
            base.InicializaTabela();
        }

    }
}
