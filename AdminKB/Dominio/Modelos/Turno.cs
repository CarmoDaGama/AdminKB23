using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "Turnos")]
    public class Turno
    {
        public int TurnoId { get; set; }
        public int CaixaId { get; set; }
        public Caixa Caixa { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public bool Estado { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFecho { get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal SaldoVendas { get; set; }
        public decimal SaldoTotalNoCaixa { get; set; }
        public decimal QuebraCaixa { get; set; }
        public decimal SaldoInformado { get; set; }
        public DateTime DataConfirmacao { get; set; }
        public bool Confirmado { get; set; }
        public string SuperVisor { get; set; } = "Desconhecido";
        public int SuperVisorId { get; set; }
        public string Descricao { get; set; }
        public string StrEstado { get { return Estado ? "ABERTO" : "FECHADO"; } }
        public string StrConfirmado { get { return Confirmado ? "SIM" : "NÃO"; } }
    }
}