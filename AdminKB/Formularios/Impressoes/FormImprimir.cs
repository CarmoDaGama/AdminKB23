using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Drawing.Printing;

namespace AdminKB.Formularios.Impressoes
{
    public partial class FormImprimir : XtraForm
    {

        private PrintResult ResultImprimir { get; set; }
        private bool Imprimir { get; set; }
        private bool FormatTicket { get; set; }

        public FormImprimir()
        {
            InitializeComponent();
        }

        private void CarregarImpressorasInstaladas()
        {
            cboImpressora.Properties.Items.Clear();
            foreach (string strImpressora in PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Properties.Items.Add(strImpressora);
            }
        }
        public bool PrintReport(XtraReport report, bool formarTicket)
        {

            cboFormato.Enabled = true;
            FormatTicket = formarTicket;
            ShowDialog();
            if (Imprimir)
            {
                report = SelectFormat(report);
                TrocarMoeda(report);
                switch (ResultImprimir)
                {
                    case PrintResult.Cancel:
                        return false;
                    case PrintResult.View:
                        new FormApresentaReport().ApresentarReport(report);
                        return true;
                    case PrintResult.Print:
                        report.Print(cboImpressora.Text);
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }

        }
        public FormImprimir SetDescricao(string descricao)
        {
            lblDescricao.Text = "Documento: " + descricao;
            return this;
        }
        private XtraReport SelectFormat(XtraReport report)
        {
            if (cboFormato.Text == "Ticket")
            {
                var method = report.GetType().GetMethod("Ticket");
                if (!Equals(method, null))
                {
                    return (XtraReport)method.Invoke(report, new object[] { });
                }
            }
            return report;
        }

        private void TrocarMoeda(XtraReport report)
        {
            //if (cboMoeda.SelectedItem.ToString() == "Dolar")
            //{
            //    Globais.MoedaActual = TipoMoeda.Dolar;
            //}
            //else
            //{
            //    Globais.MoedaActual = TipoMoeda.Kwanza;
            //}
            //var methodChangeMoeda = report.GetType().GetMethod("ChangeMoeda");
            //if (!Equals(methodChangeMoeda, null))
            //{
            //    methodChangeMoeda.Invoke(report, new object[] { Globais.MoedaActual });
            //}
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            cboMoeda.SelectedIndex = (int)Globais.MoedaActual;
            CarregarImpressorasInstaladas();
            if (FormatTicket)
            {
                cboFormato.Properties.Items.Add("Ticket");
                cboFormato.SelectedItem = "Ticket";
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Imprimir = true;
            ResultImprimir = PrintResult.Cancel;
            Close();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            Imprimir = true;
            ResultImprimir = PrintResult.View;
            Close();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cboImpressora.SelectedItem == null || Convert.ToString(cboImpressora.SelectedItem) == Util.ImpressoraPadrao)
            {
                Mensagem.Alerta("Selecione um dispositivo para poder imprimir!");
                return;
            }
            Imprimir = true;
            ResultImprimir = PrintResult.Print;
            Close();
        }
    }
}