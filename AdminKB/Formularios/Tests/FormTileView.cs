using DevExpress.XtraEditors;
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

namespace AdminKB.Formularios.Tests
{
    public partial class FormTileView : XtraForm
    {
        public FormTileView()
        {
            InitializeComponent();
        }

        private void FormTileView_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = new List<object>()
            {
                new {
                    Imagem = Properties.Resources.ProductFull,
                    Descricao = "Banana",
                    Preco = 100.0m
                },
                new {
                    Imagem = Properties.Resources.ProductFull,
                    Descricao = "Goiaba",
                    Preco = 60.0m
                },
                new {
                    Imagem = Properties.Resources.ProductFull,
                    Descricao = "Hananas",
                    Preco = 500.0m
                }
            };
        }
    }
}