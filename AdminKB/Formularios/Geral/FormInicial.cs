using DevExpress.XtraBars.Ribbon;
using AdminKB.Aplicacoes;
using AdminKB.Formularios.Documentos;
using AdminKB.Formularios.Financas;
using AdminKB.Formularios.Produtos;
using AdminKB.Formularios.SAFT;
using AdminKB.Formularios.Usuarios;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Windows.Forms;
using AdminKB.Formularios.Clientes;
using AdminKB.Formularios.Usuarios.Acessos;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace AdminKB.Formularios.Geral
{
    public partial class FormInicial : RibbonForm
    {
        public FormInicial()
        {
            new FormCarregamento(CarregarProcessos).ShowDialog();
            //accordionControlMenu.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized;
        }
        private void AdicionarFormNesteForm(Form form)
        {
            Util.ShowFormInPanel(panelCorpo.Controls, form);
            panelCorpo.Controls.Clear();
            panelCorpo.Controls.Add(form);
            
        }
        private void ApresntarInicialFormControlo()
        {
            AdicionarFormNesteForm(new FormDocumentos());
        }
        private void FormInicial_Load(object sender, EventArgs e)
        {
            VerificarModificaoSenha();
            CarregarPermissoesAcesso();
            ApresntarInicialFormControlo();
        }

        private void CarregarPermissoesAcesso()
        {
            //foreach (var element in ribbonControl1.Elements)
            //{
            //    VerificarPermissaoElemento(element, string.Empty);
            //}
        }

        private void VerificarPermissaoElemento(AccordionControlElement element, string acesso)
        {
            var _acessoApp = new AcessoApp();
            if (string.IsNullOrEmpty(acesso))
            {
                acesso = element.Text;
            }
            else
            {
                acesso = acesso + "#" + element.Text;
            }
            if (!_acessoApp.TemAcesso(acesso))
            {
                element.Visible = false;
            }
            if (!(element.Elements is null) && element.Elements.Count > 0)
            {
                foreach (var _element in element.Elements)
                {
                    VerificarPermissaoElemento(_element, acesso);
                }
            }
        }

        private void CarregarProcessos()
        {
            if (InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate {
                    InitializeComponent();
                }));
            }
            else
            {       
                InitializeComponent();
            }
        }

        private void VerificarModificaoSenha()
        {
            var _usaurioApp = new UsuarioApp();
            if (!_usaurioApp.SenhaModificada(Globais.UsuarioIdActual))
            {
                if (!Mensagem.Questao("É obrigatorio alterar a senha deste usuário.\nPretende alterar?"))
                {
                    Close();
                    return;
                }
                if(new FormSalvaUsuario().ActualizarUsuario(Globais.UsuarioIdActual))
                {
                    Globais.UsuarioActual = _usaurioApp.RetornaUsuarioPorId(Globais.UsuarioIdActual);
                    Globais.UsuarioActual.Modificado = true;
                    _usaurioApp.Actualizar(Globais.UsuarioActual);
                    if (Globais.EstadoDoTurno)
                    {
                        Globais.TurnoActual.Usuario = Globais.UsuarioActual;
                    }
                }
                else
                {
                    Mensagem.Alerta("Não foi possível alterar usuário!");
                    VerificarModificaoSenha();
                }
            }
        }

        private void btnRegistraProduto_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormProdutos());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTurno_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormTurnoDoUsuario());
        }

        private void btnDocumentos_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormDocumentos());
        }

        private void elementVender_Click(object sender, ItemClickEventArgs e)
        {
            new FormEditorDocumento().ShowDialog();
        }

        private void btnEntradaProduto_Click(object sender, ItemClickEventArgs e)
        {
            new FormEditorDocumento().CriarDocumento("ASE");
        }

        private void btnTransferenciaProdutos_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormAcertoEstoque("TP"));
        }

        private void btnSaidaProduto_Click(object sender, ItemClickEventArgs e)
        {
            new FormEditorDocumento().CriarDocumento("ASS");
        }

        private void btnFactura_Click(object sender, ItemClickEventArgs e)
        {
            new FormEditorDocumento().CriarDocumento("FT");
        }

        private void btnFacturaProforma_Click(object sender, ItemClickEventArgs e)
        {
            new FormEditorDocumento().CriarDocumento("PP");
        }

        private void btnRegistosTurnos_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormRegistrosTurnos());
        }

        private void btnReceberPagamentos_Click(object sender, ItemClickEventArgs e)
        {
            if (!Globais.EstadoDoTurno)
            {
                if (Mensagem.Questao("Não pode efectuar esta operação sem abrir turno.\nPretende abrir turno?"))
                {
                    if (new FormAbrirTurno().AbrirTurno())
                    {
                        Mensagem.Alerta("Turno aberto com sucesso!");
                        AdicionarFormNesteForm(new FormReceberPagamento());
                    }
                    else
                    {
                        Mensagem.Alerta("Não foi possível abrir turno!");
                    }
                }
                else
                {
                }
            }
            else
            {
                AdicionarFormNesteForm(new FormReceberPagamento());
            }
        }

        private void btnEmpresa_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormSalvaEmpresa());
        }

        private void btnFormasPagamento_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormFormasPagamentos());
        }

        private void btnUsuarios_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormUsuarios());
        }

        private void btnSaft_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormSafts());
        }

        private void btnDocumentosFin_Click(object sender, EventArgs e)
        {
            AdicionarFormNesteForm(new FormDocumentos());
        }

        private void btnClientes_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormClientes());
        }

        private void btnPermissoesAcessos_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormAcessos());
        }

        private void btnImpostos_Click(object sender, ItemClickEventArgs e)
        {
            AdicionarFormNesteForm(new FormImpostos());
        }

        private void btnUsuarioLagodo_Click(object sender, ItemClickEventArgs e)
        {
            new FormUsuarioInfo().ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, ItemClickEventArgs e)
        {

        }
    }
}