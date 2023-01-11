using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using AdminKB.Aplicacoes;
using Dominio.Utilitarios;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Dominio.Modelos;

namespace AdminKB.Formularios.SAFT
{
    public partial class FormSalvaSaft : XtraForm
    {
        private bool SaftGerado { get; set; }
        private string NomeFicheiroSaft { get; set; }

        public FormSalvaSaft()
        {
            InitializeComponent();
        }

        private void txtCaminhoPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fileDialog = new FolderBrowserDialog();

            Ficheiro.CriarPasta(Ficheiro.PastaSaft);
            fileDialog.SelectedPath = Ficheiro.PastaSaft;

            fileDialog.ShowDialog();
            txtCaminhoPasta.Text = fileDialog.SelectedPath;
        }

        public bool GerarNovo()
        {
            ShowDialog();
            return SaftGerado;
        }

        private void FormSalvaSaft_Load(object sender, EventArgs e)
        {
            dateInicio.EditValue = Util.RetornaDataVencime(-30);
            dateTermino.EditValue = DateTime.Now;
            txtCaminhoPasta.Text = Ficheiro.PastaSaft;
            txtSenha.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            
        }

        private void btnSalvarUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (PodeGerarSaft())
            {
                var saftApp = new SaftApp();
                var auditFile = saftApp.RetornaAuditFile(dateInicio.DateTime, dateTermino.DateTime);
                var strDataNow = DateTime.Now.ToString("yyyy-MM-dd_HHmm");
                NomeFicheiroSaft = Globais.NomeSoftware + "Saft" + strDataNow;
                MetodosSaft.Salvar(auditFile, Ficheiro.PastaSaft, NomeFicheiroSaft);
                saftApp.Adicionar(new Saft
                {
                    Caminha = txtCaminhoPasta.Text + NomeFicheiroSaft, 
                    DataCadastro=DateTime.Now, 
                    DataFim = dateTermino.DateTime,
                    DataInicio = dateInicio.DateTime
                });
                btnAbrirSaft.Visibility =  BarItemVisibility.Always;
            }
        }

        private bool PodeGerarSaft()
        {
            if (string.IsNullOrEmpty(txtCaminhoPasta.Text))
            {
                Mensagem.Alerta("Selecione pasta que será gravada o ficheiro SAFT");
                return false;
            }
            if ((dateTermino.DateTime - dateInicio.DateTime).Days <= 0)
            {
                Mensagem.Alerta("Não é possível gerar o ficheiro SAFT com este intervalo de datas!");
                return false;
            }
            return true;
        }

        private void btnAbrirSaft_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(NomeFicheiroSaft))
            {
                Process.Start(txtCaminhoPasta.Text  + NomeFicheiroSaft + ".xml");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}