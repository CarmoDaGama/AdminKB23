using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class EstoqueApp : AppBase<Estoque>
    {
        public EstoqueApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new Estoque() {
                  Nome="Geral"
            });
            base.InicializaTabela();
        }
    }
}
