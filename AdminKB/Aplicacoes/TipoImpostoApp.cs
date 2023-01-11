using Dominio.Modelos;

namespace AdminKB.Aplicacoes
{
    public class TipoImpostoApp : AppBase<TipoImposto>
    {
        public TipoImpostoApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new TipoImposto()
            {
                Sigla = "IVA",
                Descricao = "Imposto sobre o valor acrescentado",
            });
            Adicionar(new TipoImposto()
            {
                Sigla = "IS",
                Descricao = "Imposto do Selo",
            });
            Adicionar(new TipoImposto()
            {
                Sigla = "NS",
                Descricao = "Não Sujeição a IVA ou IS",
            });
            base.InicializaTabela();
        }
    }
}
