using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
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

namespace AdminKB.Formularios.Clientes
{
    public partial class FormClientes : RibbonForm
    {
        private ClienteApp _ClienteApp;

        private List<Cliente> Clientes { get; set; }

        public FormClientes()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _ClienteApp = new ClienteApp();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            CarregarClientes();
            CarregarPermissoesAcesso();
        }
        private void CarregarPermissoesAcesso()
        {
            var _acessoApp = new AcessoApp();

            if (!_acessoApp.TemAcesso("INICIO#CLIENTES#" + btnNovo.Caption))
            {
                btnNovo.Visibility = BarItemVisibility.Never;
            }
            if (!_acessoApp.TemAcesso("INICIO#CLIENTES#" + btnEliminar.Caption))
            {
                btnEliminar.Visibility = BarItemVisibility.Never;
            }
            if (_acessoApp.TemAcesso("INICIO#CLIENTES#Actualizar"))
            {
                this.GradeClientes.DoubleClick += new System.EventHandler(this.GradeClientes_DoubleClick);
            }
        }
        private void CarregarClientes()
        {
            Clientes = _ClienteApp.BuscaTodosRegistros();
            GradeClientes.DataSource = Clientes;
        }

        private void btnNovo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (new FormSalvaCliente().Adicionar())
            {
                IniciarAplicacoes();
                CarregarClientes();
            }
        }

        private void GradeClientes_DoubleClick(object sender, EventArgs e)
        {
            if (gridClientes.RowCount > 0)
            {
                var clienteId = Util.RetornaIdNaGrade(gridClientes, "ClienteId");
                var result = Clientes.Where(f => f.ClienteId == clienteId).FirstOrDefault();
                if (!(result is null))
                {
                    if (result.Nome == Globais.ClientePadrao)
                    {
                        Mensagem.Alerta("Não é possível alterar este cliente!");
                        return;
                    }
                    if (new FormSalvaCliente().Actualizar(clienteId))
                    {
                        IniciarAplicacoes();
                        CarregarClientes();
                    }
                }
            }
        }

        private void btnEliminar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (gridClientes.RowCount > 0)
                {

                    var clienteId = Util.RetornaIdNaGrade(gridClientes, "ClienteId");
                    var result = Clientes.Where(f => f.ClienteId == clienteId).FirstOrDefault(); 
                    if (result.Nome == Globais.ClientePadrao)
                    {
                        Mensagem.Alerta("Não é possível eliminar este cleinte!");
                        return;
                    }
                    if (!(result is null) && Mensagem.TemCerteza())
                    {
                        _ClienteApp.Remover(result);
                        IniciarAplicacoes();
                        CarregarClientes();
                    }
                }
            }
            catch (Exception ex)
            {
                Mensagem.Alerta("Não é possível eliminar este cleinte!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}