using Dominio.Modelos;

namespace AdminKB.Aplicacoes
{
    public class CategoriaApp : AppBase<Category>
    {
        public CategoriaApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new Category()
            {
                Name = "Desconhecida"
            });
            base.InicializaTabela();
        }
    }
}
