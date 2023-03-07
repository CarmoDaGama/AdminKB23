using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "FormaPagamentos")]
    public class FormaPagamento
    {
        public int FormaPagamentoId { get; set; }
        public string Descricao { get; set; }
        //public int ContaBancariaId { get; set; }
        //public ContaBancaria ContaBancaria { get; set; }
        public string Banco { get; set; }
        public string IBAN { get; set; } 
        public string Numero { get; set; }
        public string TipoConta { get; set; } = "Conta de 1.º grau da contabilidade geral";
    }
}
