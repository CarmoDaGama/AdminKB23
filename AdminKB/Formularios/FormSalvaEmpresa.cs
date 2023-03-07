using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Drawing;
using System.IO;

namespace AdminKB.Formularios
{
    public partial class FormSalvaEmpresa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private EmpresaApp _EmpresaApp;
        //private TelefoneEmpresaApp _PhoneCompanyApp;

        private Empresa ThisEmpresa { get; set; }

        public FormSalvaEmpresa()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _EmpresaApp = new EmpresaApp();
            //_PhoneCompanyApp = new TelefoneEmpresaApp();
        }

        private void btnSalvar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ValidFields())
            {
                LoadEntityEmpresa();
                SaveCompany();
            }
        }
        private void picImage_Click(object sender, EventArgs e)
        {
            picImage.LoadImage();
            ThisEmpresa.Imagem = Imagem.ImageToByte(picImage.Image);
        }

        private void FormSaveEmpresa_Load(object sender, EventArgs e)
        {
            txtslogan.Enabled = true;
            LoadDataEmpresa();
            CarregarPermissoesAcesso();
        }

        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("INICIO#EMPRESA#" + btnSalvar.Caption))
            {
                btnSalvar.Visibility = BarItemVisibility.Never;
            }
        }
        private void LoadDataEmpresa()
        {
            ThisEmpresa = _EmpresaApp.BuscaTipoEntidadePadrao();
            if (!(ThisEmpresa is null))
            {
                txtNome.Text = ThisEmpresa.Nome;
                txtNIF.Text = ThisEmpresa.Nif;
                txtTelefone.Text = ThisEmpresa.Telefone;
                txtEmail.Text = ThisEmpresa.Email;
                txtslogan.Text = ThisEmpresa.Slogan;
                txtMorada.Text = ThisEmpresa.Endereco;
                txtSite.Text = ThisEmpresa.Website;
                picImage.Image = RetornaImagemEmpresa(ThisEmpresa.ImagemPath);
                cboTipoEmpresa.SelectedItem = ThisEmpresa.Tipo;
                txtAdmin.Text = ThisEmpresa.SocioGerente;
            }
        }

        private Image RetornaImagemEmpresa(string imagemPath)
        {
            if (!File.Exists(imagemPath))
            {
                return Properties.Resources.Company_500px;
            }
            else
            {
                return Image.FromFile(imagemPath);
            }
        }

        private void LoadEntityEmpresa()
        {
            ThisEmpresa.Nome = txtNome.Text;
            ThisEmpresa.Nif = txtNIF.Text;
            ThisEmpresa.Email = txtEmail.Text;
            ThisEmpresa.Slogan = txtslogan.Text;
            ThisEmpresa.Endereco = txtMorada.Text;
            ThisEmpresa.Website = txtSite.Text;
            ThisEmpresa.ImagemPath = picImage.GetLoadedImageLocation();
            ThisEmpresa.Tipo = cboTipoEmpresa.SelectedItem.ToString();
            ThisEmpresa.SocioGerente = txtAdmin.Text;
        }
        private void btnSalverFechar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ValidFields())
            {
                LoadEntityEmpresa();
                SaveCompany();
                Close();
            }
        }

        private void SaveCompany()
        {
            if (ThisEmpresa.EmpresaId <= 0)
            {
                _EmpresaApp.Adicionar(ThisEmpresa);
            }
            else
            {
                _EmpresaApp.Actualizar(ThisEmpresa);
            }
        }

        private bool ValidFields()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                Mensagem.Alerta("Preencha o campo Nome!");
                return false;
            }
            if (string.IsNullOrEmpty(txtNIF.Text))
            {
                Mensagem.Alerta("Preencha o campo NIF!");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                Mensagem.Alerta("Preencha o campo Tel!");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                Mensagem.Alerta("Preencha o campo E-mail!");
                return false;
            }
            if (string.IsNullOrEmpty(txtMorada.Text))
            {
                Mensagem.Alerta("Preencha o campo Localização!");
                return false;
            }
            if (string.IsNullOrEmpty(txtslogan.Text))
            {
                Mensagem.Alerta("Preencha o campo Slogan!");
                return false;
            }
            if (string.IsNullOrEmpty(cboTipoEmpresa.SelectedItem +""))
            {
                Mensagem.Alerta("Preencha o campo Tipo!");
                return false;
            }
            return true;
        }

        private void picImage_EditValueChanged(object sender, EventArgs e)
        {
            var t = picImage.GetLoadedImageLocation();
        }

        private void picImage_ImageChanged(object sender, EventArgs e)
        {
        }
    }
    }
