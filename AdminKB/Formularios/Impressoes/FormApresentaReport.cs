using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Impressoes
{
    public partial class FormApresentaReport : XtraForm
    {
        public FormApresentaReport()
        {
            InitializeComponent();
        }

        private void FormApresentaReport1_Load(object sender, EventArgs e)
        {

        }
        public void ApresentarReport(XtraReport report)
        {
            UnableParametersReport(report.Parameters);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
            ShowDialog();
        }

        private void UnableParametersReport(ParameterCollection parameters)
        {
            foreach (var parameter in parameters)
            {
                parameter.Visible = false;
            }
        }
    }
}