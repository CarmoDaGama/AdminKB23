using DevExpress.XtraReports.UI;
using Dominio.Modelos;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace AdminKB.Relatorios.Cabecalhos
{
    public partial class ReportCabecalhoTicket : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCabecalhoTicket(Empresa empresa)
        {
            InitializeComponent();
            xrPictureBox1.ImageUrl = empresa.ImagemPath;
            lblNome.Text = empresa.Nome;
            lblEmail.Text = empresa.Email;
            lblEndereco.Text = empresa.Endereco;
            lblNif.Text = empresa.Nif;
            //lblSlogan.Text = empresa.Slogan;
        }

    }
}
