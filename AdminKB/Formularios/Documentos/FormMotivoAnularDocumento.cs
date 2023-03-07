using DevExpress.XtraBars;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Documentos
{
    public partial class FormMotivoAnularDocumento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMotivoAnularDocumento()
        {
            InitializeComponent();
        }

        public ResultadoForm<string> GetMotivoAnulacaoDoc()
        {
            ShowDialog();

            return new ResultadoForm<string>()
            {
                Resultado = DialogResult,
                Valor = cboMotivo.Text
            };
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboMotivo.Text))
            {
                Mensagem.Alerta("Não é possível gravar um motivo vazio");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtMotivo_Enter(object sender, EventArgs e)
        {
        }

        private void txtMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnGravar_Click(sender, e);
            }
        }

        private void FormMotivoAnularDocumento_Load(object sender, EventArgs e)
        {
            cboMotivo.SelectedIndex = 0;
        }
    }
}