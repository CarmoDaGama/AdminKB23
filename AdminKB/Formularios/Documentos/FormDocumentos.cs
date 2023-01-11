using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Geral;
using AdminKB.Formularios.Impressoes;
using Dominio.Modelos;
using AdminKB.Relatorios;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Dominio.Enumerados;

namespace AdminKB.Formularios.Documentos
{
    public partial class FormDocumentos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private DocumentoApp _documentoApp;
        private TipoDocumentoApp _TipoApp;
        private UsuarioApp _userApp;
        private ProdutoMovimentacaoApp _ProdutoMovimentacaoApp;
        private DocumentoAnuladoApp _docAnuladoApp;

        private List<Documento> Documentos { get; set; }
        private List<TipoDocumento> TipoDocumentos { get; set; }


        private string TodosTiposDocumento { get { return "TODOS"; } }
        private Usuario UserLogged { get; set; }

        public FormDocumentos()
        {
            new FormCarregamento(LoadRequiredData).ShowDialog();
        }

        #region Metodos
        private void ConfigureAccessPermissions()
        {
            if (UserLogged.Acesso.Nome == Globais.NomeAcessoAdmin)
            {
                btnAnularDocumentos.Enabled = true;
            }
            CarregarPermissoesAcesso();
        }
        private bool CheckAccessOnOperation(string nomeOperation)
        {
            if (UserLogged.Acesso.Nome == Globais.NomeAcessoAdmin)
            {
                return true;
            }
            else
            {

                return new AcessoApp().TemAcesso("INICIO#DOCUMENTOS#Tipo#" + nomeOperation);
            }
        }
        private void IniciarAplicacoes()
        {
            _documentoApp = new DocumentoApp();
            _TipoApp = new TipoDocumentoApp();
            _userApp = new UsuarioApp();
            _ProdutoMovimentacaoApp = new ProdutoMovimentacaoApp();
            _docAnuladoApp = new DocumentoAnuladoApp();
        }

        private void LoadOperations()
        {
            TipoDocumentos = _TipoApp.BuscaTodosRegistros();
            CboOperations.Properties.Items.Clear();
            TipoDocumentos.Add(new TipoDocumento()
            {
                Destino = Destino.Isento,
                Financeiro = MovFinanceiro.Isento,
                Estoque =  MovEstoque.Isento,
                Nome = TodosTiposDocumento,
                Sigla = "--"
            });
            foreach (TipoDocumento tipo in TipoDocumentos)
            {
                if (CheckAccessOnOperation(tipo.Nome) || tipo.Nome == TodosTiposDocumento)
                {
                    if (!CboOperations.Properties.Items.Contains(tipo.Nome))
                    {
                        CboOperations.Properties.Items.Add(tipo.Nome);
                    }
                }
            }
            CboOperations.SelectedItem = TodosTiposDocumento;
        }
        private TipoDocumento RetornaTipoDocumentoSelected()
        {
            return TipoDocumentos.Where(td => td.Nome == CboOperations.SelectedItem + "")
                .FirstOrDefault();
        }
        private void CarregarDocumentos()
        {
            var tipoDocumentoSelected = RetornaTipoDocumentoSelected();
            if (tipoDocumentoSelected is null)
            {
                return;
            }
            var dateInit = Convert.ToDateTime(DateInit.EditValue);
            var dateEnd = Convert.ToDateTime(DateEnd.EditValue);
            if (tipoDocumentoSelected.Nome == TodosTiposDocumento)
            {
                if (Globais.UsuarioActual.Acesso.Nome == Globais.NomeAcessoAdmin)
                {
                    Documentos = _documentoApp.RetornaDocumentoPorIntervaloDatas(dateInit, dateEnd);
                }
                else
                {
                    Documentos = _documentoApp.RetornaDocumentoPorUsuarioIdAndIntervaloDatas(Globais.UsuarioIdActual, dateInit, dateEnd);
                }
            }
            else
            {
                if (Globais.UsuarioActual.Acesso.Nome == Globais.NomeAcessoAdmin)
                {
                    Documentos = _documentoApp.RetornaDocumentosPorTipoId(tipoDocumentoSelected.TipoDocumentoId, dateInit, dateEnd);
                }
                else
                {
                    Documentos = _documentoApp.RetornaDocumentosPorUsuarioId_TipoDocumentoIdAndIntervalo(Globais.UsuarioIdActual, tipoDocumentoSelected.TipoDocumentoId, dateInit, dateEnd);
                }
            }
            Documentos = Documentos.Where(d => d.Estado != EstadoDocumento.Apagado).ToList();
            GradeDocumentos.DataSource = null;
            GradeDocumentos.DataSource = Documentos;
            CalcAndShowBalances(dateInit, dateEnd);
        }
        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("INICIO#DOCUMENTOS#" + btnAnularDocumentos.Text))
            {
                btnAnularDocumentos.Visible = false;
            }

            if (!_acessoApp.TemAcesso("INICIO#DOCUMENTOS#" + btnNovoDocumento.Text))
            {
                btnNovoDocumento.Visible = false;
            }
            if (!_acessoApp.TemAcesso("INICIO#DOCUMENTOS#" + btnImprensao.Text))
            {
                btnImprensao.Visible = false;
            }
        }

        private void CalcAndShowBalances(DateTime dateInit, DateTime dateEnd)
        {
            var creditBalance = Documentos.Where(d => d.Tipo.Financeiro == MovFinanceiro.Credito && d.Estado ==  EstadoDocumento.Fechado).Sum(d => d.Total);
            var debitBalance = Documentos.Where(d => d.Tipo.Financeiro ==  MovFinanceiro.Debito && d.Estado == EstadoDocumento.Fechado).Sum(d => d.Total);
            var balance = creditBalance - debitBalance;
            txtCredito.Text = Util.MostrarValorNaMoedaActual(creditBalance);
            txtDebito.Text = Util.MostrarValorNaMoedaActual(debitBalance);
            txtSaldo.Text = Util.MostrarValorNaMoedaActual(balance);
            txtLucro.Text = Util.MostrarValorNaMoedaActual(GetProfitThisAllDocument());
        }

        private decimal GetProfitThisAllDocument()
        {
            var profit = 0.0m;

            foreach (var document in Documentos)
            {
                if (document.Estado != EstadoDocumento.Fechado)
                {
                    continue;
                }
                if (document.Tipo.Financeiro ==  MovFinanceiro.Debito)
                {
                    var balance = document.Total;
                    if (document.Tipo.Estoque == MovEstoque.Debita)
                    {
                        balance = _ProdutoMovimentacaoApp.RetornaLocroProdutosPorDocumentoId(document.DocumentoId);
                    }
                    profit -= balance;
                }
                else if (document.Tipo.Financeiro ==  MovFinanceiro.Credito)
                {
                    var balance = document.Total;
                    if (document.Tipo.Estoque ==  MovEstoque.Debita)
                    {
                        balance = _ProdutoMovimentacaoApp.RetornaLocroProdutosPorDocumentoId(document.DocumentoId);
                    }
                    profit += balance;
                }
            }

            return profit;
        }

        public FormDocumentos UnableButtonClose()
        {
            btnFecharDoc.Visible = false;

            return this;
        }
        private void LoadRequiredData()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate {
                    InitializeComponent();
                    LoadData();
                }));
            }
            else
            {
                InitializeComponent();
                LoadData();
            }
        }

        private void LoadData()
        {
            IniciarAplicacoes();
            UserLogged = _userApp.RetornaUsuarioPorId(Globais.UsuarioIdActual);
            DateInit.EditValue = Util.RetornaDataVencime(-2);
            DateEnd.EditValue = Util.RetornaDataVencime(2);
            ConfigureAccessPermissions();
            LoadOperations();
            CarregarDocumentos();
        }

        private int GetDocumentoIdByIndexGrid()
        {
            var documentoId = Convert.ToInt16(gridDocumentos.GetRowCellValue(gridDocumentos.GetSelectedRows()[0], "DocumentoId"));

            return documentoId;
        }
        private Documento GetDocumentoByIndexGrid()
        {
            var documentoId = Convert.ToInt16(gridDocumentos.GetRowCellValue(gridDocumentos.GetSelectedRows()[0], "DocumentoId"));

            var selectedDocument = _documentoApp.RetornaDocumentoPorId(documentoId);
            return selectedDocument;
        }
        private void ChooseOperation(int documentoId)
        {
            var documento = _documentoApp.RetornaDocumentoPorId(documentoId);
            var carregarDocs = false;
            switch (documento.Tipo.Sigla)
            {
                case "NC":
                    Print(documento, new ReportNotaCredito(documento.DocumentoId));
                    break;

                case "RG":
                    Print(documento, new ReportRecibo(documento.DocumentoId));
                    break;
                case "ASSE":
                    carregarDocs = new FormEditorDocumento().MostrarDocumento(documentoId);
                    break;
                case "ASSS":
                    carregarDocs = new FormEditorDocumento().MostrarDocumento(documentoId);
                    break;
                case "TP":
                    Mensagem.Alerta("Em processo de Implementação!");
                    break;
                default:
                    carregarDocs = new FormEditorDocumento().MostrarDocumento(documentoId);
                    break;
            }
            if (carregarDocs)
            {
                IniciarAplicacoes();
                CarregarDocumentos();
            }
        }

        private void PrintDocument(int documentoId)
        {
            var documento = _documentoApp.RetornaDocumentoPorId(documentoId);
            switch (documento.Tipo.Sigla)
            {
                case "NC":
                    Print(documento, new ReportNotaCredito(documento.DocumentoId));
                    break;

                case "RG":
                    Print(documento, new ReportRecibo(documento.DocumentoId));
                    break;
                case "FT":
                    Print(documento, new ReportFactura(documento.DocumentoId));
                    break;
                case "FR":
                    Print(documento, new ReportFactura(documento.DocumentoId));
                    break;
                //case "CF":
                //    Print(documento, new ReportFactura(documento.DocumentoId));
                //    break;
                //case "ASE":
                //    Print(documento, new ReportFactura(documento.DocumentoId));
                //    break;
                //case "ASS":
                //    Print(documento, new ReportFactura(documento.DocumentoId));
                //    break;
                default:
                    Mensagem.Alerta("Em processo de Implementação!");
                    break;
            }
        }

        private void CancelDocumentMovArtigos(int documentoId)
        {
            var selectedDocument = GetDocumentoByIndexGrid();
            if (selectedDocument.Estado == EstadoDocumento.Fechado)
            {
                if (new FormDevolverDocumento().DevolverArtigoDoc(selectedDocument.DocumentoId))
                {
                    Mensagem.Alerta("Doumento Anulado com sucesso");
                }
            }
            else
            {
                AnularDocument(documentoId);
            }
        }

        private void AnularDocument(int documentoId)
        {
            var result = new FormMotivoAnularDocumento().GetMotivoAnulacaoDoc();
            if (result.Resultado == DialogResult.OK)
            {

                _ProdutoMovimentacaoApp.DevolverTodosProdutosMovimentacao(documentoId);
                _docAnuladoApp.Adicionar(new DocumentoAnulado()
                {
                    DocumentoId = documentoId,
                    Data = DateTime.Now,
                    Motivo = result.Valor
                });
                SaveDocAnulado(documentoId);

                Mensagem.Alerta("Doumento Anulado com sucesso");
            }
        }

        private void AnularDocumentWithoutArtigo(int documentoId)
        {
            var result = new FormMotivoAnularDocumento().GetMotivoAnulacaoDoc();
            if (result.Resultado ==  DialogResult.OK )
            {

                //_artigoMovApp.DevolverArtigoMovsAll(documentoId);
                _docAnuladoApp.Adicionar(new DocumentoAnulado()
                {
                    DocumentoId = documentoId,
                    Data = DateTime.Now,
                    Motivo = result.Valor
                });
                SaveDocAnulado(documentoId);

                Mensagem.Alerta("Doumento Anulado com sucesso");
            }
        }

        private void SaveDocAnulado(int documentoId)
        {
            var documentAnular = _documentoApp.RetornaDocumentoPorId(documentoId);
            documentAnular.Estado = EstadoDocumento.Anulado;
            _documentoApp.Actualizar(documentAnular);

        }
        private void CancelDocuments()
        {
            var canLoad = false;
            var selectedDocument = GetDocumentoByIndexGrid();
            switch (selectedDocument.Tipo.Sigla)
            {
                case "FT":
                    CancelDocumentMovArtigos(selectedDocument.DocumentoId);
                    canLoad = true;
                    break;

                case "FR":
                    CancelDocumentMovArtigos(selectedDocument.DocumentoId);
                    canLoad = true;
                    break;

                case "ASS":
                    CancelDocumentMovInv(selectedDocument.DocumentoId);
                    canLoad = true;
                    break;

                case "ASE":
                    CancelDocumentMovInv(selectedDocument.DocumentoId);
                    canLoad = true;
                    break;

                case "CF":
                    CancelDocumentMovInv(selectedDocument.DocumentoId);
                    canLoad = true;
                    break;

                default:
                    Mensagem.Alerta("Não é possível Anular este documento!");
                    break;
            }
            if (canLoad)
            {
                CarregarDocumentos();
            }
        }

        private void CancelDocumentMovInv(int documentoId)
        {
            var selectedDocument = GetDocumentoByIndexGrid();
            var result = new FormMotivoAnularDocumento().GetMotivoAnulacaoDoc();
            if (result.Resultado ==  DialogResult.OK)
            {
                if (selectedDocument.Tipo.Estoque == MovEstoque.Credita)
                {
                    _ProdutoMovimentacaoApp.DevolverArtigoMovsEntrada(documentoId);
                }
                else if (selectedDocument.Tipo.Estoque == MovEstoque.Debita)
                {
                    _ProdutoMovimentacaoApp.DevolverArtigoMovsSaida(documentoId);
                }
                _docAnuladoApp.Adicionar(new DocumentoAnulado()
                {
                    DocumentoId = documentoId,
                    Data = DateTime.Now,
                    Motivo = result.Valor
                });
                SaveDocAnulado(documentoId);

                Mensagem.Alerta("Doumento Anulado com sucesso");
            }
        }

        private bool CanCancelDocument()
        {
            var selectedDocument = GetDocumentoByIndexGrid();
            if (selectedDocument.Estado == EstadoDocumento.Anulado ||
                selectedDocument.Estado == EstadoDocumento.Apagado)
            {
                Mensagem.Alerta("Este documento já foi anulado!");
                return false;
            }

            return true;
        }
        #endregion

        private void Print(Documento documento, XtraReport report)
        {
            if (documento.Estado == EstadoDocumento.Fechado /*|| !documento.Liquidado*/)
            {
                bool imprimido;
                if ("FT-FR-ASE-ASS".Contains(documento.Tipo.Sigla))
                {
                    imprimido = new FormImprimir()
                        .SetDescricao(documento.Tipo.Nome)
                        .PrintReport(report, true);
                }
                else
                {
                    
                    imprimido = new FormImprimir()
                        .SetDescricao(documento.Tipo.Nome)
                        .PrintReport(report, false);
                }
                if (imprimido)
                {
                    documento.EstadoImpressao = Util.VerMudarEstadoImpresao(documento.EstadoImpressao);
                    _documentoApp.Actualizar(documento);
                }
            }
            else
            {
                Mensagem.Alerta("Não é possível imprimir esta " + documento.Tipo.Nome.ToLower() + " pois ainda esta aberta");
            }
        }

        private void FormDocumentos_Load(object sender, System.EventArgs e)
        {
        }

        private void btnNovoDocumento_Click(object sender, System.EventArgs e)
        {
            var tipoDocumento = RetornaTipoDocumentoSelected();
            if (tipoDocumento.Nome != TodosTiposDocumento)
            {
                CreateDocument(tipoDocumento);
            }
            else
            {
                Mensagem.Alerta("Selecione um Tipo De documento para poder criar novo documento!");
            }
        }

        private void CreateDocument(TipoDocumento tipo)
        {
            switch (tipo.Sigla)
            {
                case "FT":
                    Invoicing();
                    break;
                case "FR":
                    Invoicing();
                    break;
                case "ASE":
                    Invoicing();
                    break;
                case "ASS":
                    Invoicing();
                    break;
                case "TP":
                    InvoicingEstoque();
                    break;
                default:
                    Mensagem.Alerta("Não é possível criar este tipo de documento!");
                    break;
            }
        }

        private void InvoicingEstoque()
        {
            Mensagem.Alerta("Em processo de implementação"); 
        }

        private void Invoicing()
        {
            var operationSelected = RetornaTipoDocumentoSelected();
            if (new FormEditorDocumento().CriarDocumento(operationSelected.Sigla))
            {
                IniciarAplicacoes();
                CarregarDocumentos();
            }
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            IniciarAplicacoes();
            CarregarDocumentos();
        }

        private void GradeDocumentos_DoubleClick(object sender, System.EventArgs e)
        {
            if (gridDocumentos.RowCount > 0)
            {
                if (Globais.TurnoActual.Estado)
                {
                    var documentoId = GetDocumentoIdByIndexGrid();
                    ChooseOperation(documentoId);
                }
                else
                {
                    Mensagem.Alerta("Não é possível ver este documento, pois o turno esta fechado!");
                }
            }
        }

        private void btnFecharDoc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CboOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarDocumentos();
        }

        private void btnImprecao_Click(object sender, EventArgs e)
        {
            if (gridDocumentos.RowCount <= 0)
            {
                Mensagem.Alerta("Não existe nenhum documento para ser imprimido!");
            }
            else
            {
                PrintDocument(GetDocumentoIdByIndexGrid());
            }
        }

        private void btnAnularDocumentos_Click(object sender, EventArgs e)
        {
            if (gridDocumentos.RowCount > 0)
            {
                if (CanCancelDocument())
                {
                    CancelDocuments();
                }
            }
        }

        private void DateInit_EditValueChanged(object sender, EventArgs e)
        {
            //var dateInit = Convert.ToDateTime(DateInit.EditValue);
            //var dateEnd = Convert.ToDateTime(DateEnd.EditValue);
        }
    }
}