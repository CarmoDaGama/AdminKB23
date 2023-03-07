using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using FoxLearn.License;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Documentos;
using AdminKB.Formularios.Geral;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Modelos.ModulosVer;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AdminKB.Dominio.Enumerados;

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormLogin : XtraForm
    {
        private LicencaApp _LicensaApp;
        private ConexaoApp _ConexaoApp;
        private UsuarioApp _UsuarioApp;

        private List<LicensaVer> Licencas { get; set; }
        private bool GravouLicenca { get; set; }
        private bool LicencaActiva { get; set; } = true;
        private bool ConexaoConfigurada { get;  set; }
        public FormLogin()
        {
            new FormCarregamento(CarregarProcessos).ShowDialog();
            if (ConexaoConfigurada)
            {
                if (!LicencaActiva)
                {
                    SolucionarLicencaInactiva();
                }
                //listLicensas.DataSource = Licencas;
            }
            else
            {
                IrConfigurarConexao();
            }
        }

        private void IrConfigurarConexao()
        {
            if (Mensagem.Questao("A conexão com banco de dados não foi configurado.\nPretende configurar?"))
            {
                navigationFrame.SelectedPage = pageServidor;
                //btnVoltarLoginConfig.Visible = false;
                //panelActivar.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (PodeEntrar())
            {
                if (_UsuarioApp.Logar(txtUserName.Text, txtPassword.Text))
                {
                    Program.InicializeBadeDados();
                    Util.ExecutarMetodoNoutraThread(this, delegate {
                        Visible = false;
                        txtPassword.Text = string.Empty;
                        MostrarForm();
                        //Globais.UsuarioActual.Logado = false;
                        //_UsuarioApp.Actualizar(Globais.UsuarioActual);
                        Visible = true;
                    });
                }
                else
                {
                    Mensagem.Alerta("Não foi possivel Entrar no sistema!");
                }
            }
        }

        private void MostrarForm()
        {
            var _acessoApp = new AcessoApp();

            if (!Globais.AcessoAdmin && _acessoApp.TemAcesso("APENAS FACTURAÇÃO"))
            {
                new FormEditorDocumento().CriarDocumento("FR");
            }
            else
            {
                new FormInicial().ShowDialog();
            }
        }

        private bool PodeEntrar()
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                Mensagem.Alerta("Insira o nome e a palavra passa");
                return false;
            }
            if (!_LicensaApp.ExisteLicencaActiva())
            {
                SolucionarLicencaInactiva();
                return false;
            }
            return true;
        }

        private void btnConfiguracaoBD_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = pageServidor;
        }

        private void btnLicensa_Click(object sender, EventArgs e)
        {
            //navigationFrame.SelectedPage = pageLicensa;
            //listLicensas.Focus();
        }

        private void btnVoltarLoginGonfig_Click(object sender, EventArgs e)
        {
            navigationFrame.SelectedPage = pageLogin;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
        }

        private void CarregarProcessos()
        {
            Util.ExecutarMetodoNoutraThread(this, delegate
            {
                InitializeComponent();
                CarregarAlcanceConexaoBaseDados();
                if (ConexaoConfigurada)
                {
                    InicializaDados();
                    CarregarLicensas();
                    LicencaActiva = _LicensaApp.ExisteLicencaActiva();
                }
                else
                {
                    Mensagem.Alerta("Erro na conexão com o banco de dados");
                    navigationFrame.SelectedPage = pageServidor;
                    //BtnFecharAplicacao.Location = btnVoltarLoginConfig.Location;
                    //btnVoltarLoginConfig.Visible = false;
                    pageServidor.Controls.Add(btnClose);
                }
                RenderizarLabels();
            });
        }
        private void SolucionarLicencaInactiva()
        {
            if (Mensagem.Questao("Não existe uma licença com prazo de validade.\nPretende activar uma nova licença?"))
            {
                //navigationFrame.SelectedPage = pageLicensa;
                //btnVoltarLoginLic.Visible = false;
                //panelActivar.Visible = true;
            }
            else
            {
                Application.Exit();
            }
        }
        private void RenderizarLabels()
        {
            //var width = Width / 3;
            //lblEstado.Size = new Size(width, lblEstado.Height);
            //lblModulo.Size = new Size(width, lblModulo.Height);
            //lblPeriodo.Size = new Size(width, lblPeriodo.Height);
        }

        private void CarregarLicensas()
        {
            //txtDispositivoId.Text = ComputerInfo.GetComputerId();
            Licencas = _LicensaApp.BuscaLicensas();
        }

        private void InicializaDados()
        {
            _LicensaApp = new LicencaApp();
            _ConexaoApp = new ConexaoApp();
            _UsuarioApp = new UsuarioApp();
        }

        private void FormLogin_Resize(object sender, EventArgs e)
        {
            RenderizarLabels();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            //Clipboard.SetText(txtDispositivoId.Text);
        }

        private void btnGravarLicensa_Click(object sender, EventArgs e)
        {
            if (PodeGravarLicenca())
            {
                new FormCarregamento(GravarLicenca).ShowDialog();
                if (GravouLicenca)
                {
                    //Mensagem.Alerta("Licença gravada com sucesso!");
                    //listLicensas.DataSource = Licencas;
                    //btnVoltarLoginLic.Visible = true;
                    //navigationFrame.SelectedPage = pageLogin;
                    //panelActivar.Visible = false;
                    //GravouLicenca = false; 
                    //txtChaveLicensa.Text = string.Empty;
                }
                else
                {
                    Mensagem.Alerta("Chave da licença invalida!");
                }
            }
        }

        private void GravarLicenca()
        {
            //GravouLicenca = _LicensaApp.GravarLicensa(new Licenca()
            //{
            //    CaminhoLicensa = string.Format(@"{0}\ch.lic", Application.StartupPath),
            //    Chave = txtChaveLicensa.Text
            //});
            //if (GravouLicenca)
            //{ 
            //    CarregarLicensas();
            //}

        }

        private bool PodeGravarLicenca()
        {
            //if (string.IsNullOrEmpty(txtChaveLicensa.Text))
            //{
            //    Mensagem.Alerta("Insira a chave da licença");
            //    return false;
            //}
            return true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnEntrar_Click(sender, e);
            }
        }

        private void checkPalavraPasse_CheckedChanged(object sender, EventArgs e)
        {

            txtPassword.Properties.UseSystemPasswordChar = checkBoxViewPass.CheckState != CheckState.Checked;
        }

        private void BtnFecharAplicacao_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboSGBD_SelectedIndexChanged(object sender, EventArgs e)
        {
            MudarAlcanceConexaoBaseDados();
        }

        private void MudarAlcanceConexaoBaseDados()
        {
            if (CboTipoBD.SelectedIndex == 0)
            {
                //txtNomeBD.ReadOnly = true;
                txtServidor.ReadOnly = false;
                txtUser.ReadOnly = false;
                txtPwd.ReadOnly = false;
                txtPortaBd.ReadOnly = false;
            }
            else
            {
                var conexaoActual = new Conexao();
                CboTipoBD.SelectedIndex = (int)conexaoActual.Tipo;
                //txtNomeBD.Text = conexaoActual.BaseDeDados;
                txtServidor.Text = conexaoActual.Servidor;
                //TxtUsuarioBD.Text = conexaoActual.Usuario;
                txtPwd.Text = conexaoActual.Senha;
                txtPortaBd.Text = conexaoActual.Porta.ToString();
                //txtNomeBD.ReadOnly = true;
                txtServidor.ReadOnly = true;
                txtUser.ReadOnly = true;
                txtPwd.ReadOnly = true;
                txtPortaBd.ReadOnly = true;
            }
        }

        private void CarregarAlcanceConexaoBaseDados()
        {
            _ConexaoApp = new ConexaoApp();
            var conexaoActual = Ficheiro.LerConexaoNoFicheiro();
            if (conexaoActual is null)
            {
                conexaoActual = new Conexao();
                ConexaoConfigurada = false;
            }
            else if(_ConexaoApp.MudarConexao(conexaoActual))
            {
                ConexaoConfigurada = true;
            }
            else
            {
                ConexaoConfigurada = false;
            }
            CboTipoBD.SelectedIndex = (int)conexaoActual.Tipo;
            //txtNomeBD.Text = conexaoActual.BaseDeDados;
            txtServidor.Text = conexaoActual.Servidor;
            txtUser.Text = conexaoActual.Usuario;
            txtPwd.Text = conexaoActual.Senha;
            txtPortaBd.Text = conexaoActual.Porta.ToString();

            if (conexaoActual.Tipo ==  SGBD.SQLSEVER)
            {
                //txtNomeBD.ReadOnly = true;
                txtServidor.ReadOnly = false;
                txtUser.ReadOnly = false;
                txtPwd.ReadOnly = false;
                txtPortaBd.ReadOnly = false;
            }
            else
            {
                //txtNomeBD.ReadOnly = true;
                txtServidor.ReadOnly = true;
                txtUser.ReadOnly = true;
                txtPwd.ReadOnly = true;
                txtPortaBd.ReadOnly = true;
            }
        }

        private void btnActualizarConexao_Click(object sender, EventArgs e)
        {
            var conexao = Ficheiro.LerConexaoNoFicheiro();
            conexao = new Conexao
            {
                ConexaoId = 0,
                Tipo =  (SGBD)CboTipoBD.SelectedIndex, 
                BaseDeDados = "db_kb",
                Porta = int.Parse(txtPortaBd.Text),
                Senha = txtPwd.Text,
                Servidor = txtServidor.Text,
                Usuario = txtUser.Text
            };
            if (_ConexaoApp.MudarConexao(conexao))
            {
                ConexaoConfigurada = true;
                InicializaDados();
                CarregarLicensas();
                LicencaActiva = _LicensaApp.ExisteLicencaActiva();
                InicializaDados();
                Mensagem.Alerta("Conexão actualizada com sucesso!");
                //BtnFecharAplicacao.Location = new Point(309, 449);
                //btnVoltarLoginConfig.Visible = true;
                //pageConfiguracaoBD.Controls.Remove(BtnFecharAplicacao);
                pageLogin.Controls.Add(btnClose);
                if (!LicencaActiva)
                {
                    SolucionarLicencaInactiva();
                }
                else
                {
                    navigationFrame.SelectedPage = pageLogin;
                    //btnVoltarLoginConfig.Visible = true;
                }
                //listLicensas.DataSource = Licencas;
            }
            else
            {
                Mensagem.Alerta("Não foi possível actualizar a conexão!");
            }
        }
    }
}