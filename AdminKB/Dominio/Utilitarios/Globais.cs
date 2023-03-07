using DevExpress.Utils.Svg;
using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Modelos;
using System.IO;
using System.Windows.Forms;

namespace AdminKB.Dominio.Utilitarios
{
    public static class Globais
    {
        public static string StringConexaoPadrao { get { return "DataSource = \"db_ksoft.sdf\"; Password = \"\""; } }
        public static string StringConexao { get; set; } = Util.BuscaConexaoPadrao();
        public static int DiferencaDeDisEntreDatasValidade { get; set; } = 1;
        public static bool EstadoDoTurno { get { return !(TurnoActual is null) && TurnoActual.Estado; } }
        public static TipoMoeda MoedaActual { get; set; } = TipoMoeda.Kwanza;
        public static Turno TurnoActual { get; set; } = new Turno { TurnoId = 1, Estado = true };
        public static Usuario UsuarioActual { get; set; }
        public static string ClientePadrao { get { return "Consumidor Final";   } }

        public static bool PermitirLinhasDoMesmoArtigo { get; internal set; }
        public static decimal CambioActual { get; set; } = 430.90m;
        public static string NumeroDoCertificadoNaAGT { get { return "0000"; } }

        public static string AnoDaCertificao { get { return "2022"; } }

        public static Imposto ImpostoPadrao { get; set; }
        public static string NomeAcessoAdmin { get { return "ADMINISTRADOR"; } }
        public static string NomeAcessoVendedor { get { return "VENDEDOR"; } }
        public static int UsuarioIdActual { get; set; }
        public static string MetodoPagamentoPadrao { get; set; } = "NUMERARIO";

        public static string NIFDaKivembaSoft { get { return "5000682594"; } }
        public static string NomeSoftware { get { return "KISOFT"; } }
        public static string NomeProdutoSoftware { get { return "KivembaSoft"; } }
        public static string TelefoneProdutoSoftware { get { return ""; } }
        public static string EmailProdutoSoftware { get { return "KivembaSoft@gmail.com"; } }
        public static string WebSiteProdutoSoftware { get { return "www.kivembasoft.com"; } }
        public static string VersaoSistema { get { return "1.0"; } }

        public static SvgImage ProductFull { get; set; }
        public static bool AcessoAdmin {
            get {
                return NomeAcessoAdmin == AcessoActual.Nome; 
            } 
        }

        public static string NomePrimeiroAdmin { get { return "admin"; } }

        public static string PathImagemEmpresa { 
            get 
            {
                var path = Application.StartupPath + @"\img\";
                if (!Directory.Exists(path))
                {
                    Ficheiro.CriarPasta(path);
                }
                return path;
            }
        }

        public static Acesso AcessoActual { get; set; }
    }
}

