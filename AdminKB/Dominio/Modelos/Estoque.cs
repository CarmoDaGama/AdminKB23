﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name:"Estoques")]
    public class Estoque
    {
        public int EstoqueId { get; set; }
        public string Nome { get; set; }
    }
}