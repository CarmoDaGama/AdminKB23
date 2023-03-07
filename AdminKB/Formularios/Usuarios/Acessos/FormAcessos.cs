using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using AdminKB.Aplicacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Usuarios.Acessos
{
    public partial class FormAcessos : XtraForm
    {
        private AcessoApp _AcessoApp;

        private bool Selecionado { get; set; }
        private List<Acesso> Acessos { get; set; }

        public FormAcessos()
        {
            InitializeComponent();
            InicializarAplicacoes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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

        private void CarregarAcessos()
        {
            Acessos = _AcessoApp.RetornaAcessos();
            GradeAcessos.DataSource = Acessos;
        }
        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("CONFIGURAÇÕES#PERMISSÕES#" + btnNovo.Caption))
            {
                btnNovo.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("CONFIGURAÇÕES#PERMISSÕES#" + btnEliminar.Caption))
            {
                btnEliminar.Visibility = BarItemVisibility.Never;
            }
            if (_acessoApp.TemAcesso("CONFIGURAÇÕES#PERMISSÕES#Actualizar"))
            {
                this.GradeAcessos.DoubleClick += new System.EventHandler(this.gridAcessos_DoubleClick);
            }
        }

        private void InicializarAplicacoes()
        {
            _AcessoApp = new AcessoApp();
        }

        public new DialogResult ShowDialog()
        {
            btnClose.Visible = true;
            return base.ShowDialog();
        }
        public Acesso RetornaAcessoSelecionado()
        {
            RenderizarVisualizacaoDoForm();
            if (Selecionado)
            {
                var acessoId = Util.RetornaIdNaGrade(gridAcessos, "AcessoId");
                return _AcessoApp.RetornaAcessoPorId(acessoId);
            }
            return null;
        }

        private void FormAcessos_Load(object sender, EventArgs e)
        {
            CarregarPermissoesAcesso();
            CarregarAcessos();
        }
        private void gridAcessos_DoubleClick(object sender, EventArgs e)
        {
            if (gridAcessos.RowCount > 0)
            {
                var indiceAcesso = gridAcessos.GetSelectedRows()[0];
                int acessoIdSelecionada = Convert.ToInt32(gridAcessos.GetRowCellValue(indiceAcesso, "AcessoId"));
                if (btnSelecionar.Visibility == BarItemVisibility.Always)
                {
                    Selecionado = true;
                    Close();
                }
                else
                {
                    var acesso = _AcessoApp.BuscaPorId(acessoIdSelecionada);
                    if (acesso.Nome == Globais.NomeAcessoAdmin)
                    {
                        Mensagem.Alerta("Não é possivel actualizar esta Permição de Acesso!");
                    }
                    else
                    {
                        if (new FormSalvaAcesso().ActualizarUsuario(acessoIdSelecionada))
                        {
                            InicializarAplicacoes();
                            CarregarAcessos();
                        }
                    }
                    
                }
            }
        }
        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var acessoId = Util.RetornaIdNaGrade(gridAcessos, "AcessoId");
                var acesso = _AcessoApp.BuscaPorId(acessoId);
                if (acesso.Nome == Globais.NomeAcessoAdmin || acesso.Nome == Globais.NomeAcessoVendedor)
                {
                    Mensagem.Alerta("Não é possivel remover esta Permição de Acesso!");
                }
                else
                {
                    _AcessoApp.Remover(acesso);
                }
            }
            catch (Exception)
            {
                Mensagem.Alerta("Não é possivel remover esta Permição de Acesso!");
            }
        }
        private void btnSelecionar_ItemClick(object sender, ItemClickEventArgs e)
        {

            Selecionado = true;
            Close();
        }
        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (new FormSalvaAcesso().AdicionarUsuario())
            {
                InicializarAplicacoes();
                CarregarAcessos();
            }
        }
    }
}