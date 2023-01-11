using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using AdminKB.Aplicacoes;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Formularios.Geral
{
    public partial class FormListagemTabela<Tabela> : RibbonForm where Tabela : class, new()
    {
        private AppBase<Tabela> _TabelaApp;

        private int Index { get; set; }
        private List<Tabela> Entities { get; set; }
        private string NomeTabela { get; set; }
        private bool Inserir { get; set; } = true;
        private string TituloForm { get; set; }
        private bool Selected { get; set; } = false;
        private int TabelaId { get; set; }

        public FormListagemTabela()
        {
            InitializeComponent();
            InitApps();
            SetNameFieds();
        }

        private void SetNameFieds()
        {
            columnEntityId.FieldName = new Tabela().GetType().GetProperties().FirstOrDefault().Name;
        }

        private void InitApps()
        {
            _TabelaApp = new AppBase<Tabela>(true);
        }

        public FormListagemTabela<Tabela> ShowList(string nomeTabela, string titulo)
        {
            NomeTabela = nomeTabela;
            TituloForm = titulo;

            return this;
        }
        public Tabela BuscaRegistroSelecionado()
        {
            buttonSelecionar.Visibility = BarItemVisibility.Always;
            ShowDialog();
            if (Util.ListaNula(Entities) || Index <= -1)
            {
                return null;
            }
            var TabelaFound = Entities.Where(i => Convert.ToInt16(i.GetType().GetProperty(columnEntityId.FieldName).GetValue(i)) == TabelaId).FirstOrDefault();
            return TabelaFound;
        }



        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            Index = e.RowHandle;
            TabelaId = Convert.ToInt16(gridViewEntity.GetRowCellValue(Index, columnEntityId.FieldName));
        }
        private void gridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            Index = e.RowHandle;
            TabelaId = Convert.ToInt16(gridViewEntity.GetRowCellValue(Index, columnEntityId.FieldName));
        }
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            if (buttonSelecionar.Visibility == BarItemVisibility.Always)
            {
                Close();
            }
            else
            {
                activarEditar();
            }
        }
        private void frmInteligente_Load(object sender, EventArgs e)
        {
            SetTitleForm();
            panelSave.Visible = false;
            carregarListaInteligente();
            if (panelSave.Visible == true)
            {
                btnFechar.Caption = "Voltar";
            }
            else if (panelSave.Visible == false)
            {
                btnFechar.Caption = "Fechar";
            }
        }
        private void SetTitleForm()
        {
            Text = new Tabela().GetType().Name.ToUpper();
        }

        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            txtDescricao.Text = string.Empty;
            txtDescricao.Enabled = true;
            btnGravar.Enabled = true;
            btnNovo.Enabled = false;
            Inserir = true;
            panelSave.Visible = true;
            btnFechar.Caption = "Voltar";

            buttonSelecionar.Enabled = false;
            btnEliminar.Enabled = false;


        }
        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewEntity.RowCount <= 0)
            {
                Mensagem.Alerta("Lista encontra-se sem registros");
                return;
            }
            else
            {
                if (linhaSelecionada() && temCerteza())
                {
                    //var intligente = Entities.Where(i => i.Codigo == CodigoInteligente).FirstOrDefault();
                    //intligente.NomeTabela = NomeTabela;
                    //_inteligenteApp.Delete(intligente);
                    carregarListaInteligente();
                }
            }

        }

        private bool linhaSelecionada()
        {
            if (Index <= -1)
            {
                Mensagem.Alerta(
                    "Selecione um registros"
                );

                return false;
            }
            return true;
        }
        private void carregarListaInteligente()
        {
            Entities = _TabelaApp.BuscaTodosRegistros();
            gridEntity.DataSource = Entities;
            if (gridViewEntity.RowCount > 0)
            {
                TabelaId = Convert.ToInt16(gridViewEntity.GetRowCellValue(Index, columnEntityId.FieldName));
            }
        }
        private void apresentaMsg(string messagem)
        {
            Mensagem.Alerta(messagem);
        }
        private bool temCerteza()
        {
            var result = MessageBox.Show(
                "Tem certesa que pretende eliminar essa linha de registro!",
                "QUESTÃO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            return result == DialogResult.Yes;
        }
        private bool NotRequesitos()
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Mensagem.Alerta("Preencha o campo descrição!");

                return true;
            }
            return false;
        }
        private void activarEditar()
        {
            if (linhaSelecionada())
            {
                //var inteligente = Entities.Where(i => i.Codigo == CodigoInteligente).FirstOrDefault();
                txtDescricao.Text = "";
                txtDescricao.Enabled = true;
                btnGravar.Enabled = true;
                btnNovo.Enabled = false;
                Inserir = false;
                panelSave.Visible = true;
            }
        }


        private void btnGravar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (NotRequesitos())
            {
                return;
            }
            Dictionary<string, object> dadoCampos = new Dictionary<string, object>();
            dadoCampos.Add("Descricao", txtDescricao.Text);
            if (Inserir)
            {
                var newTabela = new Tabela();
                //if (_TabelaApp.VerificarDuplicacaoDoRegistro(NomeTabela, dadoCampos))
                //{
                //    Mensagem.Alerta("Erro", "A " + txtDescricao.Text + " digitada já existe", MessageBoxIcon.Error, MessageBoxButtons.OK);

                //    return;
                //}
                _TabelaApp.Adicionar(newTabela);
            }
            else
            {
                //var oldInteligente = new InteligenteViewModel()
                //{
                //    Codigo = CodigoInteligente,
                //    NomeTabela = NomeTabela,
                //    Descricao = txtDescricao.Text
                //};
                //if (_inteligenteApp.VerificarDuplicacaoDoRegistro(NomeTabela, dadoCampos))
                //{
                //    Mensagem.Alerta("Erro", "A " + txtDescricao.Text + " digitada já existe", MessageBoxIcon.Error, MessageBoxButtons.OK);

                //    return;
                //}
                //_inteligenteApp.Update(oldInteligente);
            }
            txtDescricao.Text = string.Empty;
            txtDescricao.Enabled = false;
            btnGravar.Enabled = false;
            btnNovo.Enabled = true;
            panelSave.Visible = false;
            buttonSelecionar.Enabled = true;
            btnEliminar.Enabled = true;
            carregarListaInteligente();
        }
        private void buttonSelecionar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Selected = true;
            Close();
        }

        private void btnCloser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (panelSave.Visible == true)
            {
                btnFechar.Caption = "Voltar";
                panelSave.Visible = false;
                btnNovo.Enabled = true;
                btnGravar.Enabled = false;

                buttonSelecionar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else if (panelSave.Visible == false)
            {
                btnFechar.Caption = "Fechar";
                btnNovo.Enabled = true;
                Index = -1;
                Close();
            }

        }

        private void frmInteligente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Selected)
            {
                Index = -1;
            }
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}