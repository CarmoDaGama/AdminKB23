﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "ContaBancarias")]
    public class ContaBancaria
    {
        public int ContaBancariaId { get; set; }
        public int BancoId { get; set; }
        public Bank Banco { get; set; }
        public string Numero { get; set; }
        public string Iban { get; set; }
        public string Natureza { get; set; }
        public string Swift { get; set; }
        public string Sequencia { get; set; }
    }
}