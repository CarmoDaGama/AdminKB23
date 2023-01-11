using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Aplicacoes;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormUsuarios : XtraForm
    {
        private UsuarioApp _UsuarioApp;

        private bool Selecionado { get; set; }
        public List<Usuario> Usuarios { get; private set; }

        public FormUsuarios()
        {
            InitializeComponent();
            InicializarAplicacoes();
        }


        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("CONFIGURAÇÕES#USUÁRIOS#" + btnNovo.Caption))
            {
                btnNovo.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("CONFIGURAÇÕES#USUÁRIOS#" + btnEliminar.Caption))
            {
                btnEliminar.Visibility = BarItemVisibility.Never;
            }
            if (_acessoApp.TemAcesso("CONFIGURAÇÕES#USUÁRIOS#Actualizar"))
            {
                this.GradeUsuarios.DoubleClick += new System.EventHandler(this.gridUsuarios_DoubleClick);
            }
        }
        private void RenderizarVisualizacaoDoForm()
        {
            btnSelecionar.Visibility = BarItemVisibility.Always;
            btnEliminar.Visibility = BarItemVisibility.Never;
            //btnImprmir.Visibility = BarItemVisibility.Never;
            btnNovo.Visibility = BarItemVisibility.Never;
            WindowState = FormWindowState.Normal;
            Size = new System.Drawing.Size(300, Height);
        }

        private void CarregarUsuarios()
        {
            Usuarios = _UsuarioApp.RetornaUsuarios();
            GradeUsuarios.DataSource = Usuarios;
        }

        private void InicializarAplicacoes()
        {
            _UsuarioApp = new UsuarioApp();
        }

        public new DialogResult ShowDialog()
        {
            btnClose.Visible = true;
            return base.ShowDialog();
        }
        public Usuario RetornaUsuarioSelecionado()
        {
            RenderizarVisualizacaoDoForm();
            if (Selecionado)
            {
                var usuarioId = Util.RetornaIdNaGrade(gridUsuarios, "UsuarioId");
               return _UsuarioApp.RetornaUsuarioPorId(usuarioId);                
            }
            return null;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            CarregarPermissoesAcesso();
            CarregarUsuarios();
        }
        private void gridUsuarios_DoubleClick(object sender, EventArgs e)
        {
            if (gridUsuarios.RowCount > 0)
            {
                var indiceUsuario = gridUsuarios.GetSelectedRows()[0];
                int usuarioIdSelecionada = Convert.ToInt32(gridUsuarios.GetRowCellValue(indiceUsuario, "UsuarioId"));
                if (btnSelecionar.Visibility == BarItemVisibility.Always)
                {
                    Selecionado = true;
                    Close();
                }
                else
                {
                    if (new FormSalvaUsuario().ActualizarUsuario(usuarioIdSelecionada))
                    {
                        InicializarAplicacoes();
                        CarregarUsuarios();
                    }
                }
            }
        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var usuarioId = Util.RetornaIdNaGrade(gridUsuarios, "UsuarioId");
                var usuario = _UsuarioApp.BuscaPorId(usuarioId);
                if (usuario.Nome == Globais.NomePrimeiroAdmin || usuarioId == Globais.UsuarioIdActual)
                {
                    Mensagem.Alerta("Não é possivel remover este Usuario");
                }
                else
                {
                    _UsuarioApp.Remover(usuario);
                }
            }
            catch (Exception)
            {
                Mensagem.Alerta("Não é possivel remover este usuário!");
            }
        }

        private void btnSelecionar_ItemClick(object sender, ItemClickEventArgs e)
        {

            Selecionado = true;
            Close();
        }

        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (new FormSalvaUsuario().AdicionarUsuario())
            {
                InicializarAplicacoes();
                CarregarUsuarios();
            }
        }
    }
}