using AdminKB.Aplicacoes;
using AdminKB.Dominio.Enumerados;
using AdminKB.Formularios.Impressoes;
using AdminKB.Formularios.Usuarios;
using AdminKB.Dominio.Modelos;
using AdminKB.Relatorios;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace AdminKB.Formularios.Financas
{
    public partial class FormReceberPagamento : RibbonForm
    {
        private DocumentoApp _DocumentoApp;
        private Documento DocumentoRecibo { get; set; }
        private List<Documento> DocumentosFT { get; set; }
        private List<Documento> ClientesDevedores { get;  set; }

        public FormReceberPagamento()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        public new DialogResult ShowDialog()
        {
            if (!Globais.EstadoDoTurno)
            {
                if (Mensagem.Questao("Não pode efectuar esta operação sem abrir turno.\nPretende abrir turno?"))
                {
                    if (new FormAbrirTurno().AbrirTurno())
                    {
                        Mensagem.Alerta("Turno aberto com sucesso!");
                        return base.ShowDialog();
                    }
                    {
                        Mensagem.Alerta("Não foi possível abrir turno!");
                        return DialogResult.None;
                    }
                }
                else
                {
                    return DialogResult.None;
                }
            }
            else
            {
                return base.ShowDialog();
            }
        }
        public new void Show()
        {
            if (!Globais.EstadoDoTurno)
            {
                if (Mensagem.Questao("Não pode efectuar esta operação sem abrir turno.\nPretende abrir turno?"))
                {
                    if (new FormAbrirTurno().AbrirTurno())
                    {
                        Mensagem.Alerta("Turno aberto com sucesso!");
                        base.Show();
                    }
                    {
                        Mensagem.Alerta("Não foi possível abrir turno!");
                    }
                }
                else
                {
                }
            }
            else
            {
                base.Show();
            }
        }
        private void IniciarAplicacoes()
        {
            _DocumentoApp = new DocumentoApp();

        }
        private void CarregarClientesDevedores()
        {
            ClientesDevedores = _DocumentoApp.RetornaClientesDevedores();
            gradeClientesDevedores.DataSource = ClientesDevedores;
            IniciarAplicacoes();
        }
        private void CarregarDocumentosPorPagar()
        {
            if (DocumentoRecibo is null)
            {
                Mensagem.Alerta("Selecione um cliente para efectuar pagamentos");
            }
            else
            {
                DocumentosFT = _DocumentoApp.RetornaDocumentoNaoPagosPorClienteId(DocumentoRecibo.ClienteId);
                foreach (Documento item in DocumentosFT)
                {
                    item.Total = _DocumentoApp.BuscaPorId(item.DocumentoId).Total;
                }
                gradeDocumento.DataSource = DocumentosFT;
                txtTotal.Text = Util.MostrarValorNaMoedaActual(RetornaTotalDocumentos());
                IniciarAplicacoes();
            }
        }
        private decimal RetornaTotalDocumentos()
        {
            return DocumentosFT.Sum(ft => ft.Total);
        }

        private void FormReceberPagamento_Load(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageClientesDevedores;
            CarregarClientesDevedores();
        }
        private void txtCliente_Click(object sender, EventArgs e)
        {

        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            if(PodePagarDocumentos())
            {
                var indices = gridDocumentos.GetSelectedRows();
                var documentosPorPagar = new List<Documento>();
                foreach (var item in indices)
                {
                    var documentoId = Convert.ToInt32(gridDocumentos.GetRowCellValue(item, columnDocumentoId));
                    documentosPorPagar.Add(_DocumentoApp.RetornaDocumentoPorId(documentoId));
                }
                DocumentoRecibo.DataFacturacao = DateTime.Now;
                DocumentoRecibo.DataVencimento = Util.RetornaDataVencime(30);
                DocumentoRecibo.Estado = EstadoDocumento.Fechado;
                //DocumentoRecibo.Imposto = Globais.ImpostoPadrao.Percentagem;
                //DocumentoRecibo.NomeCliente = DocumentoRecibo.Cliente.Nome;
                DocumentoRecibo.NumeroOrdem = _DocumentoApp.RetornaProximoNumeroDocumentoPorSigla("RG");
                DocumentoRecibo.Tipo = new TipoDocumentoApp().RetornaTipoDocumentoPorSigla("RG");
                DocumentoRecibo.TipoDocumentoId = DocumentoRecibo.Tipo.TipoDocumentoId;
                MudarTotaisDoRecibo(documentosPorPagar);
                //DocumentoRecibo.Turno = Globais.TurnoActual;
                DocumentoRecibo.TurnoId = Globais.TurnoActual.TurnoId;
                IniciarAplicacoes();
                DocumentoRecibo = _DocumentoApp.CriarDocumento(DocumentoRecibo);
                if (new FormPagamento().Efectuar(documentosPorPagar, DocumentoRecibo.DocumentoId))
                {
                    var imprimido = new FormImprimir().SetDescricao(DocumentoRecibo.Tipo.Nome)
                                        .PrintReport(new ReportRecibo(DocumentoRecibo.DocumentoId), false);
                    if (imprimido)
                    {
                        DocumentoRecibo = _DocumentoApp.RetornaDocumentoPorId(DocumentoRecibo.DocumentoId);
                        DocumentoRecibo.EstadoImpressao = Util.VerMudarEstadoImpresao(DocumentoRecibo.EstadoImpressao);
                    }
                    IniciarAplicacoes();
                    DocumentoRecibo.Estado = EstadoDocumento.Fechado;
                    _DocumentoApp.Actualizar(DocumentoRecibo);
                    CarregarClientesDevedores();
                    CarregarDocumentosPorPagar();
                }
                else
                {
                    _DocumentoApp.Remover(DocumentoRecibo);
                    CarregarClientesDevedores();
                    navigationFrame1.SelectedPage = pageClientesDevedores;
                }
            }
            }

        private void MudarTotaisDoRecibo(List<Documento> documentosPorPagar)
        {
            if (!(DocumentoRecibo is null) && !Util.ListaNula(documentosPorPagar))
            {
                DocumentoRecibo.Total = documentosPorPagar.Sum(ft => ft.Total);
                DocumentoRecibo.TotalIliquido = documentosPorPagar.Sum(ft => ft.TotalIliquido);
                DocumentoRecibo.Imposto = documentosPorPagar.Sum(ft => ft.Imposto);
                DocumentoRecibo.DescontoTotal = documentosPorPagar.Sum(ft => ft.DescontoTotal);
                DocumentoRecibo.Retencao = documentosPorPagar.Sum(ft => ft.Retencao);
                DocumentoRecibo.QtdLinhas = documentosPorPagar.Count();
            }
        }

        private bool PodePagarDocumentos()
        {
            if (_DocumentoApp.DataUltimoDocumentoMaiorDataActual())
            {
                Mensagem.Alerta("A data do ultimo documento criado não \npode ser maior que a data actual!");
                return false;
            }

            if (DocumentoRecibo is null)
            {
                Mensagem.Alerta("Selecione um cliente para efectuar pagamentos");
                return false;
            }
            if (gridDocumentos.RowCount <= 0)
            {
                return false;
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            navigationFrame1.SelectedPage = pageClientesDevedores;
        }
        private void gradeDocumento_DoubleClick(object sender, EventArgs e)
        {
            if (gridDocumentos.RowCount > 0)
            {
                btnPagar_Click(sender, e);
            }
        }
        private void gradeClientesDevedores_DoubleClick(object sender, EventArgs e)
        {
            if (gridClientesDevedores.RowCount > 0)
            {
                var indice = gridClientesDevedores.GetSelectedRows()[0];
                var clienteId = Convert.ToInt32(gridClientesDevedores.GetRowCellValue(indice, columnClienteId));
                var clienteClicado = ClientesDevedores.Where(d => d.ClienteId == clienteId).FirstOrDefault().Cliente;
                DocumentoRecibo = new Documento()
                {
                    ClienteId = clienteClicado.ClienteId,
                    NomeCliente = clienteClicado.Nome
                };
                txtClienteId.Text = clienteId.ToString();
                txtCliente.Text = clienteClicado.Nome;
                CarregarDocumentosPorPagar();
                navigationFrame1.SelectedPage = pagePagamentos;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            IniciarAplicacoes();
            CarregarClientesDevedores();
        }
    }
}