using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class AcessoApp : AppBase<Access>
    {
        public AcessoApp() : base(true)
        {

        }
        public bool TemAcessoRemover(string Acesso)
        {
            if (Globais.AcessoAdmin) return true;
            else
            {
                var listaAcesso = RetornaListaAcessos(Globais.UsuarioActual.AcessoId);
                bool Res = false;

                for (int i = 0; i < listaAcesso.Count - 1; i++)
                {

                    string _Acesso = Strings.Left(listaAcesso[i].Trim().ToUpper(), listaAcesso[i].ToString().Trim().Length - 1);
                    int _Valor = int.Parse(Strings.Right(listaAcesso[i], 1));

                    if (Acesso.Trim().ToUpper() == _Acesso.Trim().ToUpper() && _Valor == 1) Res = true;

                    //MessageBox.Show("Acesso:" + Acesso + "\n" + "AcessoSistema:" + _Acesso);
                }

                return Res;
            }
        }
        public bool TemAcesso(string Acesso)
        {
            if (Globais.AcessoAdmin) 
                return true;
            else
            {
                bool Res = false;
                var listaAcesso = RetornaListaAcessos(Globais.UsuarioActual.AcessoId);
                for (int i = 0; i < listaAcesso.Count - 1; i++)
                {

                    string _Acesso = Strings.Left(listaAcesso[i].Trim().ToUpper(), listaAcesso[i].ToString().Trim().Length - 1);
                    int _Valor = int.Parse(Strings.Right(listaAcesso[i], 1));

                    if (Acesso.Trim().ToUpper() == _Acesso.Trim().ToUpper() && _Valor == 1)
                        Res = true;

                    //MessageBox.Show("Acesso:" + Acesso + "\n" + "AcessoSistema:" + _Acesso);
                }

                return Res;
            }
        }
        public bool TemAcesso(string Acesso, int acessoId)
        {
            var acesso = RetornaAcessoPorId(acessoId);

            if (acesso.Nome == Globais.NomeAcessoAdmin) 
                return true;

            bool Res = false;
            var listaAcesso = RetornaListaAcessos(acessoId);
            for (int i = 0; i < listaAcesso.Count - 1; i++)
            {

                string _Acesso = Strings.Left(listaAcesso[i].Trim().ToUpper(), listaAcesso[i].ToString().Trim().Length - 1);
                int _Valor = int.Parse(Strings.Right(listaAcesso[i], 1));

                if (Acesso.Trim().ToUpper() == _Acesso.Trim().ToUpper() && _Valor == 1)
                    Res = true;

                //MessageBox.Show("Acesso:" + Acesso + "\n" + "AcessoSistema:" + _Acesso);
            }

            return Res;
        }

        public List<string> RetornaListaAcessos(int acessoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                var listAcessos = new List<string>();
                var acesso = contexto.Set<Access>().Where(ac => ac.AcessoId == acessoId).FirstOrDefault();
                if (!string.IsNullOrEmpty(acesso.Estrutura) && acesso.Estrutura != ".")
                {
                    listAcessos = acesso.Estrutura.Split('*').ToList();
                }
                return listAcessos;
            }
        }

        protected override void InicializaTabela()
        {
            Adicionar(new Access()
            {
                Descricao = "Administrador tem acesso a todas funcionalidade do sistema",
                Estrutura = ".",
                Nome = Globais.NomeAcessoAdmin
            }) ;
            base.InicializaTabela();
        }
        public Access RetornaAcessoPorId(int acessoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Access>()
                           .Where(a => a.AcessoId == acessoId)
                           .FirstOrDefault();
        }
        public List<Access> RetornaAcessos()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Access>()
                           .ToList();
        }
    }
}
