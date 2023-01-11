using DevExpress.XtraBars.Ribbon;
using AdminKB.Aplicacoes;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraBars;

namespace AdminKB.Formularios.Financas
{
    public partial class FormFormasPagamentos : RibbonForm
    {
        private FormaPagamentoApp _FormaPagamentoApp;

        private List<FormaPagamento> Formas { get; set; }

        public FormFormasPagamentos()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _FormaPagamentoApp = new FormaPagamentoApp();
        }

        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("FINANÇAS#FORMAS PAGAMENTOS#" + btnNovo.Caption))
            {
                btnNovo.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("FINANÇAS#FORMAS PAGAMENTOS#" + btnEliminar.Caption))
            {
                btnEliminar.Visibility = BarItemVisibility.Never;
            }
            if (_acessoApp.TemAcesso("FINANÇAS#FORMAS PAGAMENTOS#Actualizar"))
            {
                this.GradeFormas.DoubleClick += new EventHandler(this.GradeFormas_DoubleClick);
            }
        }

        private void CarregarFormasPagamentos()
        {
            Formas = _FormaPagamentoApp.BuscaTodosRegistros();
            GradeFormas.DataSource = Formas;
        }
        private void FormFormasPagamentos_Load(object sender, EventArgs e)
        {
            CarregarPermissoesAcesso();
            CarregarFormasPagamentos();
        }

        private void btnNovo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (new FormSalvaFormaPagamento().Adicionar())
            {
                IniciarAplicacoes();
                CarregarFormasPagamentos();
            }
        }

        private void GradeFormas_DoubleClick(object sender, EventArgs e)
        {
            if (gridFormas.RowCount > 0)
            {
                var formaPagamentoId = Util.RetornaIdNaGrade(gridFormas, "FormaPagamentoId");
                var result = Formas.Where(f => f.FormaPagamentoId == formaPagamentoId).FirstOrDefault();
                if (!(result is null))
                {
                    if (result.Descricao == Globais.MetodoPagamentoPadrao)
                    {
                        Mensagem.Alerta("Não é possível alterar esta forma!");
                        return;
                    }
                    if (new FormSalvaFormaPagamento().Actualizar(formaPagamentoId))
                    {
                        IniciarAplicacoes();
                        CarregarFormasPagamentos();
                    }
                }
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (gridFormas.RowCount > 0)
                {
                   
                    var formaPagamentoId = Util.RetornaIdNaGrade(gridFormas, "FormaPagamentoId");
                    var result = Formas.Where(f => f.FormaPagamentoId == formaPagamentoId).FirstOrDefault(); if (result.Descricao == Globais.MetodoPagamentoPadrao)
                    {
                        Mensagem.Alerta("Não é possível eliminar esta forma!");
                        return;
                    }
                    if (!(result is null) && Mensagem.TemCerteza())
                    {
                        _FormaPagamentoApp.Remover(result);
                        IniciarAplicacoes();
                        CarregarFormasPagamentos();
                    }
                }
            }
            catch (Exception)
            {
                Mensagem.Alerta("Não é possível eliminar está forma!");
            }
        }
    }
}