using Dominio.Enumerados;
using Dominio.Modelos;
using System;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class TipoDocumentoApp : AppBase<TipoDocumento>
    {
        public TipoDocumentoApp() : base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new TipoDocumento()
            {
                Nome = "FACTURA RECIBO",
                Destino = Destino.Cliente,
                Financeiro = MovFinanceiro.Credito,
                Estoque = MovEstoque.Debita,
                Sigla = "FR"
            });
            Adicionar(new TipoDocumento()
            {
                Nome = "FACTURA",
                Destino = Destino.Cliente,
                Financeiro = MovFinanceiro.Credito,
                Estoque = MovEstoque.Debita,
                Sigla = "FT"
            });
            Adicionar(new TipoDocumento()
            {
                Nome = "ACERTO DE STOCK (ENTRADA)",
                Destino = Destino.Isento,
                Financeiro = MovFinanceiro.Isento,
                Estoque = MovEstoque.Credita,
                Sigla = "ASE"
            });
            Adicionar(new TipoDocumento()
            {
                Nome = "ACERTO DE STOCK (SAIDA)",
                Destino = Destino.Isento,
                Financeiro = MovFinanceiro.Isento,
                Estoque = MovEstoque.Debita,
                Sigla = "ASS"
            });
            //Adicionar(new TipoDocumento()
            //{
            //    Nome = "TRANSFERENCIA DE PRODUTO",
            //    Destino = Destino.Isento,
            //    Financeiro = MovFinanceiro.Isento,
            //    Estoque = MovEstoque.Isento,
            //    Sigla = "TP"
            //});
            Adicionar(new TipoDocumento()
            {
                Nome = "FACTURA PROFORMA",
                Destino = Destino.Cliente,
                Financeiro = MovFinanceiro.Isento,
                Estoque = MovEstoque.Isento,
                Sigla = "PP"
            });
            Adicionar(new TipoDocumento()
            {
                Nome = "RECIBO",
                Destino = Destino.Entidade,
                Financeiro = MovFinanceiro.Credito,
                Estoque = MovEstoque.Isento,
                Sigla = "RG"
            });
            Adicionar(new TipoDocumento()
            {
                Nome = "NOTA DE CRÉDITO",
                Destino = Destino.Entidade,
                Financeiro = MovFinanceiro.Debito,
                Estoque = MovEstoque.Isento,
                Sigla = "NC"
            });
            base.InicializaTabela();
        }

        public TipoDocumento RetornaTipoDocumentoPorSigla(string tipoSigla)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
            return contexto.Set<TipoDocumento>()
                           .Where(dc => dc.Sigla == tipoSigla)
                           .FirstOrDefault();
        }
    }
}
