using Dominio.Enumerados;

namespace Dominio.Modelos
{
    public class Conexao
    {
        public int ConexaoId { get; set; }
        public int Porta { get; set; } = 1443;
        public SGBD Tipo { get; set; } = SGBD.SQLSERVERCOMPACT;
        public string Servidor { get; set; } = "(LocalDB)\\MSSQLLocalDB";
        public string BaseDeDados { get; set; } = "db_ksoft";
        public string Senha { get; set; } = "";
        public string Usuario { get; set; } = "Padrão";
    }
}
