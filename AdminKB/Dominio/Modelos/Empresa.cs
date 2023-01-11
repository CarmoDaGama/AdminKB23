using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Modelos
{
    [Table(name: "Empresas")]
    public class Empresa
    {
        public int EmpresaId { get; set; }
        public string Nome { get; set; }
        public string Nif { get; set; }
        public string Slogan { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public byte[] Imagem { get; set; }
        public string ImagemPath { get; set; }
        public string SocioGerente { get; set; }
        public string Tipo { get; set; }
        public DateTime DataInicioActividades { get; set; }
    }
}
