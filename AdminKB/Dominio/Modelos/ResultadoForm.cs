using System.Windows.Forms;

namespace AdminKB.Dominio.Modelos
{
    public class ResultadoForm<TipoValor>
    {
        public DialogResult Resultado { get; set; }
        public TipoValor Valor { get; set; }
    }
}
