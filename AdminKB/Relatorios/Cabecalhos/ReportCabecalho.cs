using DevExpress.XtraReports.UI;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;

namespace AdminKB.Relatorios.Cabecalhos
{
    public partial class ReportCabecalho : XtraReport
    {
        public ReportCabecalho(Empresa empresa)
        {
            InitializeComponent();
            //objectDataSource1.DataSource = empresa;
            //if (empresa.Imagem == null)
            //{
            //    xrPictureBox1.ImageUrl = string.Empty;
            //    xrPictureBox1.ImageUrl = @"Resources\bandicam 2022-07-06 22-04-18-172.jpg";
            //}
            //else
            //{
            //    //xrPictureBox1.ImageUrl = Properties.Resources.bandicam_2022_07_06_22_04_18_172;
            //}
            xrPictureBox1.ImageUrl = empresa.ImagemPath;
            lblNome.Text = empresa.Nome;
            lblEmail.Text = empresa.Email;
            lblEndereco.Text = empresa.Endereco;
            lblNif.Text = empresa.Nif;
            lblSlogan.Text = empresa.Slogan;
        }

    }
}
