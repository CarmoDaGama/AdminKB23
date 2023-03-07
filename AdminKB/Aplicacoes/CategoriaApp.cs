using AdminKB.Dominio.Modelos;

namespace AdminKB.Aplicacoes
{
    public class CategoriaApp : AppBase<Categoria>
    {
        public CategoriaApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new Categoria()
            {
                Nome = "Desconhecida"
            });
            base.InicializaTabela();
        }
    }
}
