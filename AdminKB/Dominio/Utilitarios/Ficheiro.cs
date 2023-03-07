using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Modelos;
using System;
using System.IO;
using System.Windows.Forms;

namespace AdminKB.Dominio.Utilitarios
{
    public static class Ficheiro
    {
        public static string PastaSaft { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SaftsXML\";
        public static void SalvaFicheiro(string caminhoArquivo, string conteudo)
        {
            if (File.Exists(caminhoArquivo))
            {
                File.Delete(caminhoArquivo);
            }
            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
            {
                writer.Write(conteudo);
            }

        }
        public static Conexao LerConexaoNoFicheiro()
        {
            var dadosconexao = LerTextoArquivo(Application.StartupPath + "\\Conn.txt");
            if (string.IsNullOrEmpty(dadosconexao))
            {
                return null;
            }
            else
            {
                var vetorDodosconexao = dadosconexao.Split(';');
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
        public static string CriarCaminho(string nameFile, int usuarioID)
        {
            var path = string.Format(Application.StartupPath + @"\{0}\", usuarioID);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += nameFile;
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            return path;
        }
        public static void IserirTexto(string Nome, string Conteudo)
        {
            StreamWriter writer = File.AppendText(Nome);

            writer.WriteLine(Conteudo);

            writer.Close();

        }
        public static string LerTextoArquivo(string Nome)
        {
            string res = "";

            if (File.Exists(Nome))
            {
                using (StreamReader Reader = new StreamReader(Nome))
                {
                    res = Reader.ReadLine();
                }
            }
            return res;
        }

        public static int EliminaArquivo(string Path)
        {
            int res = 0;

            if (File.Exists(Path))
            {
                File.Delete(Path);
                res = 1;
            }
            else res = 0;

            return res;
        }
        private static void AbrirExecutavel(string path)
        {

        }
        public static int CriarPasta( string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static string ConverterFicheiroParaBase64(string caminho)
        {
            byte[] bits = File.ReadAllBytes(caminho);
            string strbit = Convert.ToBase64String(bits);
            return strbit;
        }

    }
}