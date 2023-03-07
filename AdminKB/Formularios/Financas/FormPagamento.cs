using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Modelos.ModulosVer;
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

namespace AdminKB.Formularios.Financas
{
    public partial class FormPagamento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DocumentoApp _DocumentoApp { get; set; }
        private FormaPagamentoApp _FormaPagamentoApp { get; set; }
        private PagamentoApp _pagamentoApp { get; set; }

        private FormaPagaApp _FormaPagadaApp;

        public Documento DocumentoReciboActual { get; set; }

        private bool Efectuado { get; set; } = false;
        private List<Documento> DocumentosPorPagar { get; set; }
        public List<FormaPagaVer> FormasPay { get; set; }

        public FormPagamento()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _DocumentoApp = new DocumentoApp();
            _FormaPagamentoApp = new FormaPagamentoApp();
            _pagamentoApp = new PagamentoApp();
            _FormaPagadaApp = new FormaPagaApp();
        }

        public bool Efectuar(int documentoId)
        {
            return Efectuar(null, documentoId);
        }
        public bool Efectuar(List<Documento> documentos, int documentoId)
        {
            DocumentoReciboActual = _DocumentoApp.RetornaDocumentoPorId(documentoId);
            DocumentosPorPagar = documentos;
            ShowDialog();
            return Efectuado;
        }
        private void CarregarFormasPagamento()
        {
            FormasPay = _FormaPagamentoApp.RetornaFormasPagaVer();
            gridPagamentos.DataSource = FormasPay;
        }
        private decimal RetornaTotalDocPagar()
        {
            var totalPagar = Util.ListaNula(DocumentosPorPagar)? DocumentoReciboActual.Total : DocumentosPorPagar.Sum(doc => doc.Total);
            return totalPagar;
        }
        private decimal RetornaTotalValorEntregue()
        {
            var totalEntregue = FormasPay.Sum(f => f.Valor);
            return totalEntregue;
        }
        private void PreencherCabecalho()
        {
            txtEntidadeId.Text = DocumentoReciboActual.Cliente.ClienteId.ToString();
            txtNomeEntidade.Text = DocumentoReciboActual.NomeCliente;
            txtTotal.Text = Util.MostrarValorNaMoedaActual(RetornaTotalDocPagar());
            txtDescricao.Text = RetornaDescricaoDoPagamento();
            txtDesconto.Text = Util.MostrarValorNaMoedaActual(DocumentoReciboActual.DescontoTotal);
        }

        private string RetornaDescricaoDoPagamento()
        {
            string descricao = string.Empty;
            if (!Util.ListaNula(DocumentosPorPagar))
            {
                descricao = "Liquidação da ";
                foreach (var item in DocumentosPorPagar)
                {
                    if (descricao == "Liquidação da ")
                    {
                        descricao += item.Tipo.Sigla + " " + DateTime.Now.Year + "/" + item.NumeroOrdem;
                    }
                    else
                    {
                        descricao += ", " + item.Tipo.Sigla + " " + DateTime.Now.Year + "/" + item.NumeroOrdem ;
                    }
                }

            }
            else
            {
                descricao = "Liquidação da " + DocumentoReciboActual.Tipo.Nome + " " + DateTime.Now.Year + "/" + DocumentoReciboActual.NumeroOrdem;
            }
            return descricao.ToUpper();
        }

        private decimal RetornaTroco()
        {
            var troco = RetornaTotalValorEntregue() - RetornaTotalDocPagar();

            return troco;
        }
        private Cliente RetornaCliente()
        {
            var firstDoc = DocumentosPorPagar.FirstOrDefault();
            return firstDoc.Cliente;
        }
        private void MostrarValorEntregue()
        {
            txtValorEntrego.Text = Util.MostrarValorNaMoedaActual(RetornaTotalValorEntregue());
        }

        private void MostrarTroco()
        {
            txtTroco.Text = Util.MostrarValorNaMoedaActual(RetornaTroco());
        }

        private void ConcluirPagamento()
        {
            if (!Util.ListaNula(DocumentosPorPagar))
            {
                var novoPagamento = GravarPagamento(DocumentoReciboActual.DocumentoId, RetornaTotalDocPagar(), RetornaTroco());
                GravarFormaPagamentoUsada(novoPagamento.PagamentoId);

                foreach (var documento in DocumentosPorPagar)
                {
                    novoPagamento = null;
                    novoPagamento = GravarPagamento(documento.DocumentoId, documento.Total, 0);

                    //GravarFormaPagamentoUsada(novoPagamento.PagamentoId);
                }
            }
            else
            {
                var novoPagamento = GravarPagamento(DocumentoReciboActual.DocumentoId, RetornaTotalDocPagar(), RetornaTroco());

                GravarFormaPagamentoUsada(novoPagamento.PagamentoId);
            }
        }

        private Pagamento GravarPagamento(int documentoId, decimal total, decimal troco)
        {
            var NumeroOrdemPagamento = _pagamentoApp.RetornaProximoNumeroOrdem();
            var descricao = txtDescricao.Text.ToUpper();
                var _documento = _DocumentoApp.RetornaDocumentoPorId(documentoId);
            if (documentoId != DocumentoReciboActual.DocumentoId)
            {
                descricao = "LIQUIDAÇÃO DA " + _documento.Tipo.Nome + " " + _documento.Tipo.Sigla + "/" + _documento.NumeroOrdem; 
            }
            
            var pagamento = _pagamentoApp.Adicionar(new Pagamento
            {
                DocumentoId = documentoId,
                DocumetoReciboId = DocumentoReciboActual.DocumentoId,
                DataHora = DateTime.Now,
                Descricao = descricao.ToUpper(),
                ImpostoId = Globais.ImpostoPadrao.ImpostoId,
                MovFin = DocumentoReciboActual.Tipo.Financeiro,
                NumeroOrdem = NumeroOrdemPagamento,
                Total = total,
                Troco = troco
            });
            _documento.Liquidado = true;
            _DocumentoApp.Actualizar(_documento);
            return _pagamentoApp.RetornaPagamentoPorPagmentoId(_pagamentoApp.BuscaUltimaTipoEntidade().PagamentoId);
        }

        private void GravarFormaPagamentoUsada(int pagamentoId)
        {
            foreach (var forma in FormasPay)
            {
                if (forma.Valor > 0)
                {
                    _FormaPagadaApp.Adicionar(new FormaPaga { 
                        FormaPagamentoId = forma.FormaPagamentoId,
                        PagamentoId = pagamentoId,
                        Valor = forma.Valor
                    });
                }
            }
        }

        private List<FormaPagaVer> RetornaFormasPagamentosSelecionadas()
        {
            var formas = new List<FormaPagaVer>();
            foreach (var forma in FormasPay)
            {
                if (forma.Valor > 0)
                {
                    formas.Add(new FormaPagaVer()
                    {
                        ContaBancaria = forma.ContaBancaria,
                        ContaBancariaId = forma.ContaBancariaId,
                        Descricao = forma.Descricao,
                        FormaPagamentoId = forma.FormaPagamentoId,
                        Valor = forma.Valor
                    });
                }
            }
            return formas;
        }

        private void gridViewPagamentos_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var formaClicked = FormasPay[e.RowHandle];
            var resultValor = new FormNumero().RetornaValor(RetornaTotalDocPagar() - RetornaTotalValorEntregue(), "Valor Da Forma");

            if (resultValor.Resultado == DialogResult.OK)
            {
                var newValor = Convert.ToDecimal(resultValor.Valor);
                if (newValor < 0)
                {
                    Mensagem.Alerta("Não é suportado valores inferiores a zero!");
                }
                else
                {
                    formaClicked.Valor = newValor;
                    MostrarValorEntregue();
                    MostrarTroco();
                    var troco = RetornaTroco();
                    if (troco >= 0)
                    {
                        btnConcluir.Enabled = true;
                    }
                    else
                    {
                        btnConcluir.Enabled = false;
                    }
                }
            }
        }

        private void FormPagamento_Load(object sender, EventArgs e)
        {
            CarregarFormasPagamento();
            PreencherCabecalho();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (PodeFinalizarPagamento())
            {
                ConcluirPagamento();
                Efectuado = true;
                Close();
            }
        }

        private bool PodeFinalizarPagamento()
        {
            if (NenhumaFormaSelecionada())
            {
                Mensagem.Alerta("Selecione uma forma de pagamento!");
                return false;
            }
            return true;
        }

        private bool NenhumaFormaSelecionada()
        {
            return FormasPay.Where(f => f.Valor > 0).FirstOrDefault() is null;
        }
    }
}