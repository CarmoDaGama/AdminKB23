
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using AdminKB.Dominio.Enumerados;
using ConexaoRemota;
using System.Windows.Forms;

namespace AdminKB.Aplicacoes
{
    public class AppBase<TipoEntidade> where TipoEntidade : class
    {
        //protected DbContext Contexto;
        protected bool UmaTabela { get; set; } = true;
        public AppBase(bool umaTabela)
        {
            UmaTabela = umaTabela;
            Iniciar_Contexto(LerConexaoNoFicheiro());
            if (TabelaEstaVazia())
            {
                InicializaTabela();
            }
        }
        public void GravarConexaoNoFicheiro(string dadosConexao)
        {
            Ficheiro.SalvaFicheiro(Application.StartupPath + "\\Conn.txt", dadosConexao);
        }
        public Conexao LerConexaoNoFicheiro()
        {
            var dadosConexao = Ficheiro.LerTextoArquivo(Application.StartupPath + "\\Conn.txt");
            if (string.IsNullOrEmpty(dadosConexao))
            {
                return null;
            }
            else
            {
                var vetorDodosconexao = dadosConexao.Split(';');
                var conexao = new Conexao();
                conexao.BaseDeDados = vetorDodosconexao[0];
                conexao.Porta = Convert.ToInt32(vetorDodosconexao[1]);
                conexao.Senha = vetorDodosconexao[2];
                conexao.Servidor = vetorDodosconexao[3];
                conexao.Tipo = (SGBD)Convert.ToInt32(vetorDodosconexao[4]);
                conexao.Usuario = vetorDodosconexao[5];
                return conexao;
            }
        }
        public string RetornaStringConexao(Conexao conexao)
        {
            if (conexao is null)
            {
                conexao = new Conexao() { ConexaoId = -1 };
            }
            if (conexao.Tipo == SGBD.SQLSEVER)
            {
                var strConn = "";
                if (conexao.Porta <= 0)
                {
                    strConn = "Data Source=" + conexao.Servidor +
                       //"," + conexao.Porta +
                       //";Network Library=DBMSSOCN" +
                       ";Initial Catalog=" + conexao.BaseDeDados +
                       ";User ID=" + conexao.Usuario +
                       ";Password=" + conexao.Senha;
                }
                else
                {
                    strConn = "Data Source=" + conexao.Servidor +
                       "," + conexao.Porta +
                       ";Network Library=DBMSSOCN" +
                       ";Initial Catalog=" + conexao.BaseDeDados +
                       ";User ID=" + conexao.Usuario +
                       ";Password=" + conexao.Senha;
                }

                return strConn;
            }
            else
            {
                //return "DataSource = \"" + conexao.BaseDeDados + ".sdf\"; Password = \"" + conexao.Senha + "\"";
                return @"Data Source=" + conexao.Servidor +
                        ";AttachDbFilename=\"" + Application.StartupPath + "\\" + conexao.BaseDeDados +".mdf\"" +
                        ";Integrated Security=True" +
                        ";Connect Timeout=30";
            }
        }
        public DbContext Iniciar_Contexto(Conexao conexao)
        {
            return new ContextoSqlRemoto(RetornaStringConexao(conexao));
        }
        public void Adicionar(TipoEntidade obj)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                AnularEntidadesComponentes(obj);
                MudarEntidadesDatas(obj);
                contexto.Set<TipoEntidade>().Add(obj);
                contexto.SaveChanges();
            }
        }
        private void AnularEntidadesComponentes(TipoEntidade obj)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.PropertyType.FullName.Contains("Dominio.Modelos"))
                {
                    var novaInstancia = property.PropertyType.GetConstructors()[0].Invoke(new object[] { });
                    property.SetValue(obj, null);
                }
            }
        }
        private void MudarEntidadesDatas(TipoEntidade obj)
        {
            foreach (var property in obj.GetType().GetProperties())
            {                
                if (property.PropertyType.FullName.Contains("System.DateTime"))
                {
                    DateTime novaData = (DateTime)property.GetValue(obj);
                    novaData = new DateTime(
                        novaData.Year,
                        novaData.Month,
                        novaData.Day,
                        novaData.Hour,
                        novaData.Minute,
                        novaData.Second
                    );
                    property.SetValue(obj, novaData);
                }
            }
        }
        private void CarregarEntidadesComponentes(object obj)
        {
            foreach (var property in obj.GetType().GetProperties())
            {
                if (property.PropertyType.FullName.Contains("SistamaGestaoKSoft.Modelos"))
                {
                    int id = BuscaIdPorObjecto(property.GetValue(obj));
                    //var propertyValue = BuscaPorId(id);
                    var novaInstancia = property.PropertyType.GetConstructors()[0].Invoke(new object[] { });
                    property.SetValue(obj, novaInstancia);
                }
            }
        }
        public TipoEntidade BuscaPorId(int id)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                var objecto = contexto.Set<TipoEntidade>().Find(id);
                return objecto;
            }
        }
        public List<TipoEntidade> BuscaTodosRegistros()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                var todosRegistros = contexto.Set<TipoEntidade>().ToList();
                return todosRegistros;
            }
        }
        public void Actualizar(TipoEntidade obj)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                //TODO 'A propriedade 'OperationId' faz parte da informação chave do objeto e não pode ser modificada
                if (obj == null)
                {
                    throw new ArgumentException("Não pode adicionar uma entidade nula.");
                }
                AnularEntidadesComponentes(obj);
                MudarEntidadesDatas(obj);
                int id = BuscaIdPorObjecto(obj);
                var tmpObj = BuscaPorId(id);

                //CarregarEntidadesComponentes(obj);
                var entry = contexto.Entry<TipoEntidade>(tmpObj);
                entry.State = EntityState.Modified;
                contexto.Entry<TipoEntidade>(tmpObj).CurrentValues.SetValues(obj);
                contexto.SaveChanges();
            }
        }
        private int BuscaIdPorObjecto(object obj)
        {
            var nomeId = obj.GetType().Name + "Id";
            var objId = obj.GetType().GetProperty(nomeId).GetValue(obj);
            return Convert.ToInt16(objId);
        }
        public void Remover(TipoEntidade obj)
        {
            try
            {
                using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                {
                    int id = BuscaIdPorObjecto(obj);
                    var tmpObj = BuscaPorId(id);
                    contexto.Entry<TipoEntidade>(tmpObj).State = EntityState.Deleted;
                    //Contexto.Set<TipoEntidade>().Remove(obj);
                    contexto.SaveChanges();
                }
            }
            finally 
            {

            } 
        }
        public TipoEntidade BuscaTipoEntidadePadrao()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                var tipoEntidadePadrao = contexto.Set<TipoEntidade>().FirstOrDefault();
                Iniciar_Contexto(LerConexaoNoFicheiro());
                return tipoEntidadePadrao;
            }
        }
        public TipoEntidade BuscaUltimaTipoEntidade()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var tipoEntidadePadrao = contexto.Set<TipoEntidade>().ToList().LastOrDefault();
                return tipoEntidadePadrao;
            }
        }
        public bool TabelaEstaVazia()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return UmaTabela && contexto.Set<TipoEntidade>().ToList().Count() == 0;
        }
        protected virtual void InicializaTabela()
        {

        }
    }
}
