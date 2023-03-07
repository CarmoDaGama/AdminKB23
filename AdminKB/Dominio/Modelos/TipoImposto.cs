﻿using System.ComponentModel.DataAnnotations.Schema;

namespace AdminKB.Dominio.Modelos
{
    [Table(name: "TipoImpostos")]
    public class TipoImposto
    {
        public int TipoImpostoId { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

    }
}