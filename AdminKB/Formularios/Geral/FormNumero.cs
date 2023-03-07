using DevExpress.XtraEditors;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Windows.Forms;

namespace AdminKB.Formularios.Geral
{
    public partial class FormNumero : XtraForm
    {
        public FormNumero()
        {
            InitializeComponent();
        }

        private decimal ValorNoForm { get;  set; }

        public ResultadoForm<decimal> RetornaValor(decimal valorIncial)
        {
            ValorNoForm = valorIncial;
            ShowDialog();
            return new ResultadoForm<decimal>()
            {
                Resultado = DialogResult, 
                Valor = ValorNoForm
            };
        }
        public ResultadoForm<decimal> RetornaValor(decimal valorIncial, string titulo)
        {
            Text = titulo.ToUpper();
            ValorNoForm = valorIncial;
            ShowDialog();
            return new ResultadoForm<decimal>()
            {
                Resultado = DialogResult,
                Valor = ValorNoForm
            };
        }
        private void FormNumero_Load(object sender, EventArgs e)
        {
            txtValor.Text = ValorNoForm.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (PodeConcluir())
            {
                //if (txtValor.Text.Contains("."))
                //{
                //    var cu = Application.CurrentInputLanguage;
                //    ValorNoForm = decimal.Parse(txtValor.Text.Replace(".", ","));
                //}
                //else
                //{
                    ValorNoForm = Convert.ToDecimal(txtValor.Text);
                //}
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        private bool PodeConcluir()
        {
            var valorNoForm = Convert.ToDecimal(txtValor.Text);
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                Mensagem.Alerta("Insira um valor na caixa de texto!");
                return false;
            }
            if (valorNoForm < 0)
            {
                Mensagem.Alerta("Insira um valor maior ou igual a zero!");
                return false;
            }
            return true;
        }

        private void txtValor_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnOk_Click(sender, e);
            }
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            txtValor.Text += (sender as SimpleButton).Text;
        }
    }
}