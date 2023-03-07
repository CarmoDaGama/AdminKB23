using DevExpress.XtraEditors;
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

namespace AdminKB.Formularios.Geral
{
    public partial class FormDescricao : XtraForm
    {
        public FormDescricao()
        {
            InitializeComponent();
        }
        public ResultadoForm<string> GetDescricao(string titulo, string descricaoInitial)
        {
            Text = titulo;
            txtNome.Text = descricaoInitial;
            ShowDialog();

            return new ResultadoForm<string>{
                Resultado = DialogResult, 
                Valor = txtNome.Text
            };
        }
        private void ConcluirDescricao()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Mensagem.Alerta("Preencha o campo Nome!");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void btnOk_Click(object sender, System.EventArgs e)
        {
            ConcluirDescricao();
        }



        private void txtNome_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                ConcluirDescricao();
            }
        }
    }
}