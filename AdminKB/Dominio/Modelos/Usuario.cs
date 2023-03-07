using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Dominio.Modelos
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public int AcessoId { get; set; }
        public Acesso Acesso { get; set; }
        public string PalavraPasse { get; set; }
        public bool Modificado { get; set; }
        public bool Logado { get; set; }
        public string CodigoDeAcesso { get; set; }
    }
}
