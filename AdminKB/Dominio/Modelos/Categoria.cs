﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name:"Categorias")]
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
    }
}