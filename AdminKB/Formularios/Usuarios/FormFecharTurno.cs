using AdminKB.Aplicacoes;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormFecharTurno : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TurnoApp _TurnoApp;

        private bool Terminado { get; set; } = false;
        private Turno TurnoPorTerminar { get; set; }

        public FormFecharTurno()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _TurnoApp = new TurnoApp();
        }

        public bool TerminarTurno(int turnoId)
        {
            var _documentoApp = new DocumentoApp();
            if (_documentoApp.RetornaUltimoDocumentoAberto(turnoId) is null)
            {
                TurnoPorTerminar = _TurnoApp.RetornaTurnoPorId(turnoId);
                if (TurnoPorTerminar.Estado == false)
                {
                    Mensagem.Alerta("Este turno já se encontra fechadao!");
                }
                else
                {
                    ShowDialog();
                }
            }
            else
            {
                Mensagem.Alerta("Não é possível a fechar turno pois existem documentos abertos!");
            }
            return Terminado;
        }

        private void FormFecharTurno_Load(object sender, EventArgs e)
        {
            txtSaldoTotalCaixa.Text = (TurnoPorTerminar.SaldoTotalNoCaixa + TurnoPorTerminar.SaldoInicial).ToString("N2");
        }

        private void btnFechar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TirminarTurno();
        }

        private void TirminarTurno()
        {
            TurnoPorTerminar.Estado = false;
            TurnoPorTerminar.DataFecho = DateTime.Now;
            TurnoPorTerminar.QuebraCaixa = Convert.ToDecimal(txtSaldoQuebra.Text);
            TurnoPorTerminar.SaldoInformado = Convert.ToDecimal(txtSaldoImformado.Text);
            TurnoPorTerminar.Descricao = richTextBox1.Text;
            _TurnoApp.Actualizar(TurnoPorTerminar);
            Globais.TurnoActual = null;
            Terminado = true;
            Close();
        }

        private void txtSaldoCurrent_TextChanged(object sender, EventArgs e)
        {
            txtSaldoQuebra.Text = (Convert.ToDecimal(txtSaldoImformado.Text) - Convert.ToDecimal(txtSaldoTotalCaixa.Text)).ToString("N2");
        }

        private void txtSaldoImformado_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                TirminarTurno();
            }
        }
    }
}