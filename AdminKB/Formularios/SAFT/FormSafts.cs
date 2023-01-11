using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Aplicacoes;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.SAFT
{
    public partial class FormSafts : XtraForm
    {
        private SaftApp _SaftApp;
        private List<Saft> Safts { get; set; }

        public FormSafts()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _SaftApp = new SaftApp();
        }

        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (new FormSalvaSaft().GerarNovo())
            {
                IniciarAplicacoes();
                CarregarSafts();
            }
        }

        private void FormSafts_Load(object sender, EventArgs e)
        {
            CarregarSafts();
        }

        private void CarregarSafts()
        {
            Safts = _SaftApp.BuscaTodosRegistros();
            GradeSafts.DataSource = null;
            GradeSafts.DataSource = Safts;
        }

        private void GradeSafts_DoubleClick(object sender, EventArgs e)
        {
            if (Mensagem.TemCerteza())
            {
                var indice = gridSafts.GetSelectedRows()[0];
                var saftId = Convert.ToInt32(gridSafts.GetRowCellValue(indice, "SaftId"));
                var saftSelecionado = _SaftApp.BuscaPorId(saftId);
                if (File.Exists(saftSelecionado.Caminha+ ".xml"))
                {
                    Process.Start(saftSelecionado.Caminha+ ".xml");
                }
                else
                {
                    var auditFile = _SaftApp.RetornaAuditFile(saftSelecionado.DataInicio, saftSelecionado.DataFim);
                    var strDataNow = DateTime.Now.ToString("yyyy-MM-dd_HHmm");
                    var nomeFicheiroSaft = Globais.NomeSoftware + "Saft" + strDataNow;
                    MetodosSaft.Salvar(auditFile, Ficheiro.PastaSaft, nomeFicheiroSaft);
                    Process.Start(Ficheiro.PastaSaft + nomeFicheiroSaft + ".xml");
                }
            }
        }
    }
}