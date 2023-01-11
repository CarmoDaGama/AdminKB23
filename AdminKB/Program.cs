using AdminKB.Aplicacoes;
using AdminKB.Formularios;
using AdminKB.Formularios.Documentos;
using AdminKB.Formularios.Geral;
using AdminKB.Formularios.Produtos;
using AdminKB.Formularios.Tests;
using AdminKB.Formularios.Usuarios;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Globais.ProductFull = Properties.Resources.ProductFull;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //Globais.UsuarioActual.Logado = false;
            //new UsuarioApp().Actualizar(Globais.UsuarioActual);
        }
        public static void InicializeBadeDados()
        {
            new CategoriaApp();
            new EmpresaApp();
            new CaixaApp();
            new ClienteApp();
            new UsuarioApp();
            new TurnoApp();
            new TipoDocumentoApp();
            new EstoqueApp();
            new MotivoIsencaoApp();
            new TipoImpostoApp();
            new ImpostoApp();
            new ProdutoApp();
            new ProdutoEstoqueApp();
            new BancoApp();
            new ContaBancariaApp();
            new FormaPagamentoApp();
            Globais.ImpostoPadrao = new ImpostoApp().BuscaPorNome("Taxa Normal");

        }
    }
}
