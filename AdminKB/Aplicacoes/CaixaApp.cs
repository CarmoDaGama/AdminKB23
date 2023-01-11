using FoxLearn.License;
using Dominio.Modelos;
using Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminKB.Aplicacoes
{
    public class CaixaApp : AppBase<Caixa>
    {
        public CaixaApp():base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new Caixa()
            {
                DispositivoId = ComputerInfo.GetComputerId(),
                Nome = "Caixa Principal",
                Numero = 0
            });
            base.InicializaTabela();
        }
        public new void Adicionar(Caixa caixa)
        {
            if (!JaExisteRegistroCaixaDesteDispositivo(ComputerInfo.GetComputerId()))
            {
                caixa.Numero = BuscaNovoNumeroDoCaixa();
                caixa.Nome = "Caixa " + caixa.Numero;
                caixa.DispositivoId = ComputerInfo.GetComputerId();
                base.Adicionar(caixa);
            }
        }

        private bool JaExisteRegistroCaixaDesteDispositivo(string v)
        {
            var IdDesteDipositivo = ComputerInfo.GetComputerId();
            var caixas = BuscaTodosRegistros();
            if (Util.ListaNula(caixas))
            {
                return false;
            }
            return caixas.Where(cx => cx.DispositivoId == IdDesteDipositivo).FirstOrDefault() != null;
        }

        private int BuscaNovoNumeroDoCaixa()
        {
            var ultimoCaixa = BuscaUltimaTipoEntidade();
            var ultimoNumeroCaixa = Util.ObjectoNulo(ultimoCaixa)? 0 : ultimoCaixa.Numero;
            var novoNumero = 0;
            if (ultimoNumeroCaixa > 0)
            {
                novoNumero = ultimoNumeroCaixa + 1;
            }
            return novoNumero;
        }
    }
}
