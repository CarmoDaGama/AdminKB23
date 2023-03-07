using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using AdminKB.Aplicacoes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminKB.Formularios.Financas
{
    public partial class FormImpostos : XtraForm
    {
        private ImpostoApp _ImpostoApp;

        private bool Selecionado { get; set; }
        public List<Imposto> Impostos { get; private set; }

        public FormImpostos()
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

        private void CarregarImpostos()
        {
            Impostos = _ImpostoApp.RetornaImpostos();
            GradeImpostos.DataSource = Impostos;
        }

        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("FINANÇAS#IMPOSTOS#" + btnNovo.Caption))
            {
                btnNovo.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("FINANÇAS#IMPOSTOS#" + btnEliminar.Caption))
            {
                btnEliminar.Visibility = BarItemVisibility.Never;
            }
            if (_acessoApp.TemAcesso("FINANÇAS#IMPOSTOS#Actualizar"))
            {
                this.GradeImpostos.DoubleClick += new System.EventHandler(this.gridImpostos_DoubleClick);
            }
        }
        private void InicializarAplicacoes()
        {
            _ImpostoApp = new ImpostoApp();
        }

        public new DialogResult ShowDialog()
        {
            btnClose.Visible = true;
            return base.ShowDialog();
        }
        public Imposto RetornaImpostoSelecionado()
        {
            RenderizarVisualizacaoDoForm();
            if (Selecionado)
            {
                var impostoId = Util.RetornaIdNaGrade(gridImpostos, "ImpostoId");
                return _ImpostoApp.RetornaImpostoPorId(impostoId);
            }
            return null;
        }

        private void FormImpostos_Load(object sender, EventArgs e)
        {
            CarregarPermissoesAcesso();
            CarregarImpostos();
        }
        private void gridImpostos_DoubleClick(object sender, EventArgs e)
        {
            if (gridImpostos.RowCount > 0)
            {
                var indiceImposto = gridImpostos.GetSelectedRows()[0];
                int impostoIdSelecionada = Convert.ToInt32(gridImpostos.GetRowCellValue(indiceImposto, "ImpostoId"));
                if (btnSelecionar.Visibility == BarItemVisibility.Always)
                {
                    Selecionado = true;
                    Close();
                }
                else
                {
                    if (new FormSalvaImposto().ActualizarImposto(impostoIdSelecionada))
                    {
                        InicializarAplicacoes();
                        CarregarImpostos();
                    }
                }
            }
        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int impostoId = Util.RetornaIdNaGrade(gridImpostos, "ImpostoId");
                _ImpostoApp.Remover(_ImpostoApp.BuscaPorId(impostoId));
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
            if (new FormSalvaImposto().AdicionarImposto())
            {
                InicializarAplicacoes();
                CarregarImpostos();
            }
        }
    }
}