using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdminKB.Formularios.Produtos
{
    public partial class FormProdutos : XtraForm
    {
        private ProdutoApp _ProdutoApp;
        private ProdutoEstoqueApp _ProdutoEstoqueApp;

        public bool Selecionado { get; private set; }

        public FormProdutos()
        {
            new FormCarregamento(CarregarProcessos).ShowDialog();
        }

        public ProdutoEstoque RetornaProdutoEstoqueSelecionado()
        {
            RenderizarVisualizacaoDoForm();
            ShowDialog();
            if (Selecionado)
            {
                return RetornaProdutoEstoque();
            }
            return null;
        }

        private void RenderizarVisualizacaoDoForm()
        {
            btnSelecionar.Visibility = BarItemVisibility.Always;
            btnEliminarProduto.Visibility = BarItemVisibility.Never;
            btnImprmir.Visibility = BarItemVisibility.Never;
            btnNovoProduto.Visibility = BarItemVisibility.Never;
            WindowState = FormWindowState.Normal;
            Size = new System.Drawing.Size(300, Height);
        }

        private ProdutoEstoque RetornaProdutoEstoque()
        {
            var indiceProduto = gridProdutos.GetSelectedRows()[0];
            int produtoIdSelecionada = Convert.ToInt32(gridProdutos.GetRowCellValue(indiceProduto, "ProdutoId"));
            return _ProdutoEstoqueApp.RetornaProdutoPorId(produtoIdSelecionada);
        }

        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("ESTOQUE#PRODUTOS#" + btnNovoProduto.Caption))
            {
                btnNovoProduto.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("ESTOQUE#PRODUTOS#" + btnEliminarProduto.Caption))
            {
                btnEliminarProduto.Visibility = BarItemVisibility.Never;
            }
            if (_acessoApp.TemAcesso("ESTOQUE#PRODUTOS#Actualizar"))
            {
                this.gridProdutos.DoubleClick += new System.EventHandler(this.gridProdutos_DoubleClick);
            }
        }
        private void InicializarAplicacoes()
        {
            _ProdutoApp = new ProdutoApp();
            _ProdutoEstoqueApp = new ProdutoEstoqueApp();
        }
        private List<ProdutoEstoque> BuscaProdutos()
        {
            return (List<ProdutoEstoque>)GradeProdutos.DataSource;
        }
        private void CarregarProcessos()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate {
                    InitializeComponent();
                    InicializarAplicacoes();
                    CarregarProdutos();
                }));
            }
            else
            {
                InitializeComponent();
                InicializarAplicacoes();
                CarregarProdutos();
            }
        }
        private void CarregarProdutos()
        {
            GradeProdutos.DataSource = _ProdutoEstoqueApp.CarregarProdutos();
        }

        public new DialogResult ShowDialog()
        {
            btnClose.Visible = true;
            return base.ShowDialog();
        }


        private void btnNovoProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(new FormSalvaProduto().AdicionarProduto())
            {
                InicializarAplicacoes();
                CarregarProdutos();
            }
        }

        private void btnEliminarProduto_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridProdutos.RowCount > 0)
            {
                var indiceProduto= gridProdutos.GetSelectedRows()[0];
                int produtoIdSelecionada = Convert.ToInt32(gridProdutos.GetRowCellValue(indiceProduto, "ProdutoId"));
                _ProdutoApp.Remover(produtoIdSelecionada);
                InicializarAplicacoes();
                CarregarProdutos();
            }
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            CarregarPermissoesAcesso();
        }

        private void gridProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (gridProdutos.RowCount > 0)
            {
                var indiceProduto= gridProdutos.GetSelectedRows()[0];
                int produtoIdSelecionada = Convert.ToInt32(gridProdutos.GetRowCellValue(indiceProduto, "ProdutoId"));
                if (btnSelecionar.Visibility == BarItemVisibility.Always)
                {
                    Selecionado = true;
                    Close();
                }
                else
                {
                    if (new FormSalvaProduto().ActualizarProduto(produtoIdSelecionada))
                    {
                        InicializarAplicacoes();
                        CarregarProdutos();
                    }
                }
            }
        }
        private void gridProdutos_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
        }

        private void btnSelecionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Selecionado = true;
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}