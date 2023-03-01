using Dominio.Enumerados;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name:"Documentos")]
    public class Documento
    {
        public int DocumentoId { get; set; }
        public DateTime DataFacturacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataUltimaActualizacao { get; set; }


        public int ClienteId { get; set; }
        public Client Cliente { get; set; }
        public int TipoDocumentoId { get; set; }
        public TipoDocumento Tipo { get; set; }
        public int TurnoId { get; set; }
        public Turno Turno { get; set; }

        public EstadoDocumento Estado { get; set; }
        public EstadoImpressao EstadoImpressao { get; set; }

        public string Descricao { get; set; }
        public string NomeCliente { get; set; }
        public string Hash { get; set; }
        public string Mascara { get; set; }

        public bool Liquidado { get; set; }
        public int NumeroOrdem { get; set; }

        public decimal DescontoGlobal { get; set; }
        public decimal Imposto { get; set; }
        public decimal Retencao { get; set; }
        public decimal TotalIliquido { get; set; }
        public decimal Total { get; set; }
        public decimal DescontoTotal { get; set; }
        public int QtdLinhas { get; set; }
    }
}
