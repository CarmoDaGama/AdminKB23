using Dominio.Modelos;
using Dominio.Utilitarios;
using System.IO;

namespace AdminKB.Aplicacoes
{
    public class EmpresaApp : AppBase<Empresa>
    {
        public EmpresaApp() : base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Properties.Resources.PUBLICIDADE___MARKETING.SetResolution(100, 200);
            Adicionar(new Empresa() { 
                Nome = "KivembaSoft",
                Email="kivembasoft@gmail.com",
                Endereco = "Murro Bento, Luanda",
                //Imagem = Imagem.ImageToByte(Properties.Resources.bandicam_2022_07_06_22_04_18_172),
                Nif = "999999999", 
                Pais="Angola", 
                Provincia ="Luanda",
                Website = "www.kivembasoft.com", 
                Slogan = "Potencializamos suas venda",
                Telefone = "+244 000 000 000", 
                SocioGerente="Admin", 
                Tipo = "Empresa em nome individual",
                DataInicioActividades = System.DateTime.Now
            });
            base.InicializaTabela();
        }
        public new void Adicionar(Empresa empresa)
        {
            var novoCaminho = Globais.PathImagemEmpresa + @"ImagemEmpresa";
            if (!string.IsNullOrEmpty(empresa.ImagemPath))
            {
                string extensao = empresa.ImagemPath.Split('.')[1];
                novoCaminho = novoCaminho + extensao;
                if (File.Exists(novoCaminho))
                {
                    File.Delete(novoCaminho);
                }
                File.Copy(empresa.ImagemPath, novoCaminho);
            }
            empresa.ImagemPath = novoCaminho;
            base.Adicionar(empresa);
        }
        public new void Actualizar(Empresa empresa)
        {
            var novoCaminho = Globais.PathImagemEmpresa + @"ImagemEmpresa";
            if (!string.IsNullOrEmpty(empresa.ImagemPath))
            {
                string extensao = empresa.ImagemPath.Split('.')[1];
                novoCaminho = novoCaminho +"."+ extensao;
                if (File.Exists(novoCaminho))
                {
                    File.Delete(novoCaminho);
                }
                File.Copy(empresa.ImagemPath, novoCaminho);
            empresa.ImagemPath = novoCaminho;
            }
            else {
                empresa.ImagemPath = string.Empty; 
            }
            base.Actualizar(empresa);
        }
    }
}
