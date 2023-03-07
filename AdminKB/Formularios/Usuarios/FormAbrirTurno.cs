using DevExpress.XtraBars;
using AdminKB.Aplicacoes;
using AdminKB.Dominio.Modelos;
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

namespace AdminKB.Formularios.Usuarios
{
    public partial class FormAbrirTurno : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private TurnoApp _TurnoApp;

        private bool EstadoTurno { get; set; }
        public FormAbrirTurno()
        {
            InitializeComponent();
            IniciarAplicacoes();
        }

        private void IniciarAplicacoes()
        {
            _TurnoApp = new TurnoApp();
        }

        public bool AbrirTurno()
        {
            ShowDialog();
            return EstadoTurno;
        }

        private void btnAbrir_ItemClick(object sender, ItemClickEventArgs e)
        {
                AbriTurno();
        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                AbriTurno();
            }
        }

        private void AbriTurno()
        {
            Globais.TurnoActual = _TurnoApp.Adicionar(new Turno()
            {
                CaixaId = new CaixaApp().BuscaTipoEntidadePadrao().CaixaId,
                Confirmado = false,
                DataAbertura = DateTime.Now,
                DataConfirmacao = DateTime.Now,
                DataFecho = DateTime.Now,
                Descricao = string.Empty,
                Estado = true,
                SaldoInicial = Convert.ToDecimal(txtSaldoInicial.Text),
                UsuarioId = Globais.UsuarioIdActual
            });
            EstadoTurno = true;
            Close();
        }
    }
}