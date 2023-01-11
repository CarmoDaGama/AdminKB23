using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Dominio.Utilitarios
{
    public static class Mensagem
    {
        public static void Alerta(string msg)
        {
            XtraMessageBox.Show(msg, "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static bool Questao(string msg)
        {
            var resposta = XtraMessageBox.Show(msg, "QUESTÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return resposta == DialogResult.Yes;
        }
        public static bool TemCerteza()
        {
            return Questao("Tem certeza que prentede efectuar esta operaçao?");
        }
    }
}
