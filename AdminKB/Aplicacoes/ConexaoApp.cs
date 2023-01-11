using Dominio.Enumerados;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class ConexaoApp : AppBase<Conexao>
    {
        public Conexao ConexaoRemotaPadrao { get {
                return new Conexao {
                        Tipo = SGBD.MYSQLSERVER,
                        Porta=49172,
                        Usuario= "ksoft",
                        Senha="ksoft2022", 
                        Servidor = "(Endereço IP)\\SQLEXPRESS"
                    }; 
                }
        }

        public ConexaoApp():base(false)
        {
        }
        protected override void InicializaTabela()
        {
            base.Adicionar(new Conexao());
            base.InicializaTabela();
        }
        public new void Adicionar(Conexao conexao)
        {
            if (TabelaEstaVazia())
            {
                conexao.ConexaoId = 0;
                base.Adicionar(conexao);
            }
            else
            {
                Actualizar(conexao);
            }
        }

        public Conexao RetornaConexaoActual()
        {
            try
            {
                return LerConexaoNoFicheiro();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return null;
            }
        }

        public bool MudarConexao(Conexao conexao)
        {
            using (var contexto = Iniciar_Contexto(conexao)) { 
            if (contexto is null)
            {
                return false;
            }
            else
            {
                try
                {
                    if (contexto.Database.Exists())
                    {
                        GravarConexaoNoFicheiro(
                            conexao.BaseDeDados +";"+
                            conexao.Porta + ";" +
                            conexao.Senha + ";" +
                            conexao.Servidor + ";" +
                            ((int)conexao.Tipo) + ";" +
                            conexao.Usuario
                        );
                        return true;
                    }
                    else
                    {
                        contexto.Database.Initialize(true);
                        if(contexto.Database.Exists())
                        {
                            GravarConexaoNoFicheiro(
                            conexao.BaseDeDados + ";" +
                            conexao.Porta + ";" +
                            conexao.Senha + ";" +
                            conexao.Servidor + ";" +
                            ((int)conexao.Tipo) + ";" +
                            conexao.Usuario
                            );
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            }
        }
        public new void Actualizar(Conexao conexao)
        {
            if (TabelaEstaVazia())
            {
                Adicionar(conexao);
            }
            else
            {
                base.Actualizar(conexao);
            }
        }

    }
}
