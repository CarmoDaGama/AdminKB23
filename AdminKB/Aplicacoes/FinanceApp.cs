using AdminKB.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class FinanceApp : AppBase<BaseEntity>
    {
        private DocumentoApp documentoApp;
        private PagamentoApp pagamentoApp;
        public FinanceApp() : base(false)
        {
        }
        protected override void InicializaTabela()
        {
            documentoApp = new DocumentoApp();
            pagamentoApp = new PagamentoApp();
            base.InicializaTabela();
        }
        public decimal GetTransactionTotal(DateTime start, DateTime end)
        {
            var payments = pagamentoApp.BuscaTodosRegistros().Where(p => p.DataHora >= start && p.DataHora <= end).ToList();

            var transactionTotal = payments.Sum(p => p.Total);

            return transactionTotal;
        }

    }
}
