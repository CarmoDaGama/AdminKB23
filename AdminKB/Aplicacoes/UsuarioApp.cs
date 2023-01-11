using Dominio.Modelos;
using Dominio.Utilitarios;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class UsuarioApp : AppBase<Usuario>
    {
        public UsuarioApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            new AcessoApp();
            Adicionar(new Usuario()
            {
                AcessoId = 1,
                Nome = "admin",
                PalavraPasse = Criptografia.EncryptInMD5("admin")
            });
            base.InicializaTabela();
        }
        public bool Logar(string nome, string palavraPasse)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var passeEncriptada = Criptografia.EncryptInMD5(palavraPasse);
                var usuario = contexto.Set<Usuario>().Where(u => u.Nome == nome && u.PalavraPasse == passeEncriptada).FirstOrDefault();
                if (usuario != null)
                {
                    //if (usuario.Logado)
                    //{
                    //    Mensagem.Alerta("Este usuário já se encontra logado!");
                    //    return false;
                    //}
                    Globais.UsuarioIdActual = usuario.UsuarioId;
                    Globais.UsuarioActual = RetornaUsuarioPorId(usuario.UsuarioId);
                    //Globais.UsuarioActual.Logado = true;
                    //Actualizar(Globais.UsuarioActual);
                    Globais.TurnoActual = new TurnoApp().RetornaTurnoAbertoPorUsuarioId(usuario.UsuarioId);
                    Globais.AcessoActual = new AcessoApp().BuscaPorId(usuario.AcessoId);
                    return true;
                }
                return false;
            }
        }

        public Usuario RetornaUsuarioPorCodigoAcesso(string codigoAcesso)
        {
                var codigoAcessoEncriptado = Criptografia.EncryptInMD5(codigoAcesso);
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Usuario>()
                               .Include(u => u.Acesso)
                               .Where(u => u.CodigoDeAcesso == codigoAcessoEncriptado)
                               .FirstOrDefault();
        }

        public Usuario RetornaUsuarioPorId(int usuarioId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<Usuario>()
                           .Include(u => u.Acesso)
                           .Where(u => u.UsuarioId == usuarioId)
                           .FirstOrDefault();
        }

        public List<Usuario> RetornaUsuarios()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<Usuario>()
                           .Include(u => u.Acesso)
                           .ToList();
        }

        public bool SenhaModificada(int usuarioId)
        {
            return BuscaPorId(usuarioId).Modificado;
        }

        public List<Usuario> RetornaUsuariosPorAcessoId(int acessoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<Usuario>()
                           .Include(u => u.Acesso)
                           .Where(u => u.AcessoId == acessoId)
                           .ToList();
        }

        public bool VerificarPasse(string palavraPasse)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var passeEncriptada = Criptografia.EncryptInMD5(palavraPasse);
                var usuario = contexto.Set<Usuario>().Where(u => u.PalavraPasse == passeEncriptada).FirstOrDefault();
                return !(usuario is null);
            }
        }
        public bool VerificarNome(string nome)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var usuario = contexto.Set<Usuario>().Where(u => u.Nome == nome).FirstOrDefault();
                return !(usuario is null);
            }
        }

        public bool NomeUsuarioJaExiste(string nome)
        {
            return VerificarNome(nome);
        }
        public bool CodigoAcessoJaExiste(string codigoAcesso)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            {
                var codigoAcessoEncriptado = Criptografia.EncryptInMD5(codigoAcesso);
                var usuario = contexto.Set<Usuario>().Where(u => u.CodigoDeAcesso == codigoAcessoEncriptado).FirstOrDefault();
                return !(usuario is null);
            }
        }
        public new void Adicionar(Usuario usuario)
        {
            base.Adicionar(usuario);

            usuario = RetornaUsuarioPorId(BuscaUltimaTipoEntidade().UsuarioId);
            var acesso = usuario.Acesso;
            usuario.Acesso = null;
            usuario.CodigoDeAcesso = Criptografia.EncryptInMD5(RetornaCodigoAcesso(usuario));
            Actualizar(usuario);
            usuario.Acesso = acesso;
        }
        public new void Actualizar(Usuario usuario)
        {
            base.Actualizar(usuario);
            usuario.Acesso = new AcessoApp().BuscaPorId(usuario.AcessoId);
        }
        private string RetornaCodigoAcesso(Usuario usuario)
        {
            var codigoAcesso = SSL.GerarCodigoDeAcesso(usuario);

            if (NomeUsuarioJaExiste(codigoAcesso))
            {
                return RetornaCodigoAcesso(usuario);
            }
            return codigoAcesso;
        }
    }
}
