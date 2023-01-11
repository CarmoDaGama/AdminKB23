using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using Dominio.Utilitarios;
using System;
using Dominio.Modelos;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormConfirmaTurno : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TurnoApp _TurnoApp;

        private Usuario UsuarioSupervisor { get;  set; }
        private bool Confirmado { get; set; } = false;
        private Turno TurnoPorConfirmar { get;  set; }

        public FormConfirmaTurno()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _TurnoApp = new TurnoApp();
        }
        public bool ConfirmarTurno(int turnoId)
        {
            TurnoPorConfirmar = _TurnoApp.RetornaTurnoPorId(turnoId);
            ShowDialog();
            return Confirmado;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new FormListagemTabela<Usuario>().BuscaRegistroSelecionado();
            if (!(usuario is null))
            {
                txtUsuario.Text = usuario.Nome;
                UsuarioSupervisor = usuario;
            }
        }
        private void FormConfirmaTurno_Load(object sender, EventArgs e)
        {
            if (!(TurnoPorConfirmar is null))
            {
                txtSupervisor.Text = Globais.UsuarioActual.Nome;
                UsuarioSupervisor = TurnoPorConfirmar.Usuario;
                txtUsuario.Text = TurnoPorConfirmar.Usuario.Nome;
                txtNomeCaixa.Text = TurnoPorConfirmar.Caixa.Nome;
                txtQuebraDoCaixa.Text = Util.MostrarValorNaMoedaActual(TurnoPorConfirmar.QuebraCaixa);
                txtSaldoNoCaixa.Text = Util.MostrarValorNaMoedaActual(TurnoPorConfirmar.SaldoTotalNoCaixa);
            }
        }

        private void btnConfirmarTurno_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (UsuarioSupervisor is null)
            {
                Mensagem.Alerta("Selecione um supervisor para poder confirmar o turno");
                return;
            }
            TurnoPorConfirmar.Confirmado = true;
            TurnoPorConfirmar.DataConfirmacao = DateTime.Now;
            TurnoPorConfirmar.SuperVisor = UsuarioSupervisor.Nome;
            TurnoPorConfirmar.SuperVisorId = UsuarioSupervisor.UsuarioId;
            _TurnoApp.Actualizar(TurnoPorConfirmar);
            
            Confirmado = true;
            Close();

        }
    }
}