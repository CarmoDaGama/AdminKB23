using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Modelos.ModulosVer
{
    public class MotivoIsencaoVer
    {
        public decimal TaxaValor { get; set; }
        public decimal QtdIncidencia { get; set; }
        public decimal TotalImposto { get; set; }
        public string Motivo { get; set; }
    }
}
