using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Dominio.Enumerados;
using Dominio.Modelos;
using Dominio.Utilitarios;
using AdminKB.Aplicacoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Usuarios.Acessos
{
    public partial class FormSalvaAcesso : XtraForm
    {
        private AcessoApp _AcessoApp;

        private bool Salvo { get; set; } = false;
        private Acesso AcessoSalvar { get; set; }
        private OperacoesDeFormulario Operacao { get; set; }
        public List<string> ListaGeral { get; set; }
        private string Gambiarra;
        private string Gambiarra1;
        private string Gambiarra2;
        private string Gambiarra3;

        public FormSalvaAcesso()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void btnSalvarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (PodeSalvarUsuario())
            {
                IniciarAplicacoes();
                PopularControlesNoUsuario();
                if (Operacao == OperacoesDeFormulario.ADICIONAR)
                {
                    _AcessoApp.Adicionar(AcessoSalvar);
                }
                else
                {
                    _AcessoApp.Actualizar(AcessoSalvar);
                }
                Salvo = true;
                Close();
            }
        }

        private void txtAcesso_Click(object sender, EventArgs e)
        {
            //var acesso = new FormListagemTabela<Acesso>().BuscaRegistroSelecionado();
            //if (!(acesso is null))
            //{
            //    if (AcessoSalvar is null)
            //    {
            //        AcessoSalvar = new Usuario();
            //    }
            //    AcessoSalvar.Acesso = acesso;
            //    AcessoSalvar.AcessoId = acesso.AcessoId;
            //    txtAcesso.Text = acesso.Nome;
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSalvaAcesso_Load(object sender, EventArgs e)
        {
            RenderizarNodes();
        }

        private void RenderizarNodes()
        {
        }

        private void IniciarAplicacoes()
        {
            _AcessoApp = new AcessoApp();
        }

        public bool ActualizarUsuario(int usuarioIdSelecionada)
        {
            Operacao = OperacoesDeFormulario.ACTUALIZAR;
            AcessoSalvar = _AcessoApp.RetornaAcessoPorId(usuarioIdSelecionada);
            PopularUsuarioNosControles();
            ShowDialog();
            return Salvo;
        }

        private void PopularUsuarioNosControles()
        {
            if (!(AcessoSalvar is null))
            {
                if (AcessoSalvar.Nome == Globais.NomeAcessoAdmin || AcessoSalvar.Nome == Globais.NomeAcessoVendedor)
                {
                    txtNomeAcesso.Enabled = false;
                }
                txtNomeAcesso.Text = AcessoSalvar.Nome;
                ListaParaEstrutura();
                txtDescricao.Text = AcessoSalvar.Descricao;
            }
        }
        private void PopularControlesNoUsuario()
        {
            if ((AcessoSalvar is null))
            {
                AcessoSalvar = new Acesso();
            }
            EstruturaParaTexto();
            AcessoSalvar.Nome = txtNomeAcesso.Text;
            AcessoSalvar.Descricao = txtDescricao.Text;
            //UsuarioSalvar.Acesso.Nome = txtAcesso.Text;
            if (Operacao == OperacoesDeFormulario.ADICIONAR)
            {
                //AcessoSalvar.PalavraPasse = Criptografia.EncryptInMD5(txtSenha.Text);
                //AcessoSalvar.Modificado = false;
            }
            else
            {
                //AcessoSalvar.PalavraPasse = Criptografia.EncryptInMD5(txtSenhaSeguinte.Text);
                //AcessoSalvar.Modificado = true;
            }
        }

        public bool AdicionarUsuario()
        {
            Operacao = OperacoesDeFormulario.ADICIONAR;
            //AcessoPadrao = new AcessoApp().BuscaTipoEntidadePadrao();
            //txtAcesso.Text = AcessoPadrao.Nome;
            //lblSenha.Text = "Senha";
            //lblSenhaSeguinte.Text = "Confirmar";
            ShowDialog();
            return Salvo;
        }

        private bool PodeSalvarUsuario()
        {
            if (string.IsNullOrEmpty(txtNomeAcesso.Text))
            {
                Mensagem.Alerta("Preencha o campo nome!");
                return false;
            }
            if (Operacao == OperacoesDeFormulario.ACTUALIZAR)
            {
                //if (!_AcessoApp.VerificarPasse(txtSenha.Text))
                //{
                //    Mensagem.Alerta("senha Actual está errada!");
                //    return false;
                //}
                //if (txtSenhaSeguinte.Text.Length < 6)
                //{
                //    Mensagem.Alerta("O número de caracter da senha\n têm de ser maior ou igual a seis!");
                //    return false;
                //}
            }
            else
            {
                //if (txtSenha.Text != txtSenhaSeguinte.Text)
                //{
                //    Mensagem.Alerta("A senha nova é diferente da senha de confirmação!");
                //    return false;
                //}
                //if (txtSenha.Text.Length < 6)
                //{
                //    Mensagem.Alerta("O número de caracter da senha\n têm de ser maior ou igual a seis!");
                //    return false;
                //}
            }

            return true;
        }
        private int Retornaint(string checado)
        {
            if (checado.ToUpper().Equals("CHECKED")) return 1;
            else return 0;
        }
        private void ListaParaEstrutura()
        {
            if (!(AcessoSalvar is null) && (!string.IsNullOrEmpty(AcessoSalvar.Estrutura) && AcessoSalvar.Estrutura != "."))
            {
                ListaGeral = AcessoSalvar.Estrutura.Split('*').ToList();
            }

            for (int i = 0; i < ListaGeral.Count - 1; i++)
            {
                string x = ListaGeral[i].ToString();
                int valor = int.Parse(Strings.Right(x, 1));

                string Linha = ListaGeral[i].ToString().Trim();

                string TestoLinha = Strings.Left(Linha, Linha.Length - 1);
                string[] Niveis = TestoLinha.Split('#');

                int Nivel = Niveis.Length;

                if (Nivel == 1) NivelAvo(TestoLinha, valor);
                if (Nivel == 2) NivelPai(Niveis[0], Niveis[1], valor);
                if (Nivel == 3) NivelFilho(Niveis[0], Niveis[1], Niveis[2], valor);
                if (Nivel == 4) NivelNeto(Niveis[0], Niveis[1], Niveis[2], Niveis[3], valor);
            }
        }
        private void NivelAvo(string Texto, int Valor)
        {
            for (int j = 0; j < treeViewPermissoes.Nodes.Count; j++)
            {
                string TextoArvore = treeViewPermissoes.Nodes[j].Text;
                if (Texto.Trim().ToUpper() == TextoArvore.Trim().ToUpper())
                {
                    treeViewPermissoes.Nodes[j].Checked = Convert.ToBoolean(Valor);
                }
            }
        }
        private void NivelPai(string NivelAvo, string NivelPai, int Valor)
        {
            for (int i = 0; i < treeViewPermissoes.Nodes.Count; i++)
            {
                if (treeViewPermissoes.Nodes[i].Text.Trim().ToUpper() == NivelAvo.Trim().ToUpper())
                {
                    for (int j = 0; j < treeViewPermissoes.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeViewPermissoes.Nodes[i].Nodes[j].Text.Trim().ToUpper() == NivelPai.Trim().ToUpper())
                        {
                            treeViewPermissoes.Nodes[i].Nodes[j].Checked = Convert.ToBoolean(Valor);
                        }
                    }
                }
            }
        }
        private void NivelFilho(string NivelAvo, string NivelPai, string NivelFilho, int Valor)
        {
            for (int i = 0; i < treeViewPermissoes.Nodes.Count; i++)
            {
                if (treeViewPermissoes.Nodes[i].Text.Trim().ToUpper() == NivelAvo.Trim().ToUpper())
                {
                    for (int j = 0; j < treeViewPermissoes.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeViewPermissoes.Nodes[i].Nodes[j].Text.Trim().ToUpper() == NivelPai.Trim().ToUpper())
                        {
                            for (int k = 0; k < treeViewPermissoes.Nodes[i].Nodes[j].Nodes.Count; k++)
                            {
                                if (treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Text.Trim().ToUpper() == NivelFilho.Trim().ToUpper())
                                {
                                    treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Checked = Convert.ToBoolean(Valor);
                                }
                            }
                        }
                    }
                }
            }
        }
        private void NivelNeto(string NivelAvo, string NivelPai, string NivelFilho, string NivelNeto, int Valor)
        {
            for (int i = 0; i < treeViewPermissoes.Nodes.Count; i++)
            {
                if (treeViewPermissoes.Nodes[i].Text.Trim().ToUpper() == NivelAvo.Trim().ToUpper())
                {
                    for (int j = 0; j < treeViewPermissoes.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeViewPermissoes.Nodes[i].Nodes[j].Text.Trim().ToUpper() == NivelPai.Trim().ToUpper())
                        {
                            for (int k = 0; k < treeViewPermissoes.Nodes[i].Nodes[j].Nodes.Count; k++)
                            {
                                if (treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Text.Trim().ToUpper() == NivelFilho.Trim().ToUpper())
                                {
                                    for (int l = 0; l < treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Nodes.Count; l++)
                                    {
                                        if (treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text.Trim().ToUpper() == NivelNeto.Trim().ToUpper())
                                        {
                                            treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Checked = Convert.ToBoolean(Valor);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void EstruturaParaTexto()
        {
            ListaGeral = new List<string>();

            for (int i = 0; i < treeViewPermissoes.Nodes.Count; i++)
            {
                string Avo = treeViewPermissoes.Nodes[i].Text;
                string AvoValor = treeViewPermissoes.Nodes[i].Checked.ToString();

                bool Valor = bool.Parse(AvoValor);
                if (Valor == true) { Gambiarra = "Checked"; }
                else { Gambiarra = "Unchecked"; }
                ListaGeral.Add(Avo + " " + Retornaint(Gambiarra) + "*");

                for (int j = 0; j < treeViewPermissoes.Nodes[i].Nodes.Count; j++)
                {
                    string Pai = treeViewPermissoes.Nodes[i].Nodes[j].Text;
                    string ValorPai = treeViewPermissoes.Nodes[i].Nodes[j].Checked.ToString();

                    //metodo  para receber 1 
                    bool Valor1 = bool.Parse(ValorPai);
                    if (Valor1 == true) { Gambiarra1 = "Checked"; }
                    else { Gambiarra1 = "Unchecked"; }

                    ListaGeral.Add(Avo + "#" + Pai + " " + Retornaint(Gambiarra1) + "*");

                    for (int k = 0; k < treeViewPermissoes.Nodes[i].Nodes[j].Nodes.Count; k++)
                    {
                        string Filho = treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Text;
                        string ValorFilho = treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Checked.ToString();

                        // metodo  para receber 1
                        bool Valor2 = bool.Parse(ValorFilho);
                        if (Valor2 == true) { Gambiarra2 = "Checked"; }
                        else { Gambiarra2 = "Unchecked"; }

                        ListaGeral.Add(Avo + "#" + Pai + "#" + Filho + " " + Retornaint(Gambiarra2) + "*");

                        for (int l = 0; l < treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Nodes.Count; l++)
                        {
                            string Neto = treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Text;
                            string ValorNeto = treeViewPermissoes.Nodes[i].Nodes[j].Nodes[k].Nodes[l].Checked.ToString();

                            // metodo  para receber 1
                            bool Valor3 = bool.Parse(ValorNeto);
                            if (Valor3 == true) { Gambiarra3 = "Checked"; }
                            else { Gambiarra3 = "Unchecked"; }

                            ListaGeral.Add(Avo + "#" + Pai + "#" + Filho + "#" + Neto + " " + Retornaint(Gambiarra3) + "*");
                        }
                    }
                }
            }

            AcessoSalvar.Estrutura = string.Empty;
            var textBox = new TextBox();
            for (int i = 0; i < ListaGeral.Count; i++)
            {
                textBox.AppendText(ListaGeral[i].ToString() + "\n");
                AcessoSalvar.Estrutura = textBox.Text;
            }
        }

    }
}