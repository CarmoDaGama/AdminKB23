using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormRegistrosTurnos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TurnoApp _TurnoApp;
        private UsuarioApp _UsuarioApp;

        private List<Turno> TurnosRegistado { get; set; }
        private Usuario Usuario { get;  set; }

        public FormRegistrosTurnos()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _TurnoApp = new TurnoApp();
            _UsuarioApp = new UsuarioApp();
        }

        private void CarregarProcessos()
        {
            DateInit.EditValue = Util.RetornaDataVencime(-2);
            DateEnd.EditValue = Util.RetornaDataVencime(2);
            txtUsuario.Text = Globais.UsuarioActual.Nome;
            Usuario = Globais.UsuarioActual;
            CarregarPermissoesAcesso();
            CarregarTurnos(Globais.UsuarioIdActual);
        }

        private void CarregarTurnos(int usuarioId)
        {
            TurnosRegistado = _TurnoApp.RetornaTurnos(usuarioId, (DateTime)DateInit.EditValue, (DateTime)DateEnd.EditValue);
            gradeTurnos.DataSource = TurnosRegistado;
        }

        private void FormRegistrosTurnos_Load(object sender, EventArgs e)
        {
            CarregarProcessos();
        }

        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("INICIO#REGISTROS DE TURNOS#" + btnAbrir.Caption))
            {
                btnAbrir.Visibility = BarItemVisibility.Never;
            }

            if (!_acessoApp.TemAcesso("INICIO#REGISTROS DE TURNOS#" + btnConfirmar.Caption))
            {
                btnConfirmar.Visibility = BarItemVisibility.Never;
                ribbonPageGroup1.Visible = false;
            }
        }
        private void txtUsuario_Click(object sender, EventArgs e)
        {
            var usuario = new FormListagemTabela<Usuario>().BuscaRegistroSelecionado();
            if (!(usuario is null))
            {
                txtUsuario.Text = usuario.Nome;
                Usuario = usuario;
            }
        }

        private void btnActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            IniciarAplicacoes();
            if (Usuario is null)
            {
                CarregarTurnos(Globais.UsuarioIdActual);
            }
            else
            {
                CarregarTurnos(Usuario.UsuarioId);
            }
        }

        private void gradeTurnos_DoubleClick(object sender, EventArgs e)
        {
            var turnoId = Convert.ToInt32(gridTurnos.GetRowCellValue(gridTurnos.GetSelectedRows()[0], columnTurnoId));
            if (new FormTurnoDoUsuario().MostrarTurno(turnoId))
            {
                IniciarAplicacoes();
                CarregarTurnos(Usuario.UsuarioId);
            }
        }
    }
}