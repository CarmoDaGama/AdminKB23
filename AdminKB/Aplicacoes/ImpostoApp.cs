using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class ImpostoApp : AppBase<Imposto>
    {
        public ImpostoApp() : base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new Imposto
            {
                Nome = "Isento",
                Percentagem = 0,
                Sigla = "ISE",
                TipoImpostoId = 3,
                DataVigencia = System.DateTime.Now
            });
            Adicionar(new Imposto
            {
                Nome = "Taxa Normal",
                Percentagem = 7,
                Sigla = "NOR",
                TipoImpostoId = 1,
                DataVigencia = System.DateTime.Now
            });
            Adicionar(new Imposto
            {
                Nome = "Taxa Intermédia",
                Percentagem = 7,
                Sigla = "INT",
                TipoImpostoId = 1,
                DataVigencia = System.DateTime.Now
            });
            Adicionar(new Imposto
            {
                Nome = "Taxa Reduzida",
                Percentagem = 7,
                Sigla = "RED",
                TipoImpostoId = 1,
                DataVigencia = System.DateTime.Now
            });
            Adicionar(new Imposto
            {
                Nome = "Outros, aplicável para os regimes especiais de IVA",
                Percentagem = 7,
                Sigla = "OUT",
                TipoImpostoId = 1,
                DataVigencia = System.DateTime.Now
            });
            base.InicializaTabela();
        }

        public List<Imposto> RetornaImpostos()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Imposto>()
                            .Include(imp => imp.TipoImposto)
                            .ToList();
        }

        public Imposto RetornaImpostoPorId(int impostoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Imposto>()
                            .Include(imp => imp.TipoImposto)
                            .Where(imp => imp.ImpostoId == impostoId)
                            .FirstOrDefault();
        }

        public new Imposto BuscaTipoEntidadePadrao()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Imposto>().Where(i => i.Nome == "Taxa Normal").FirstOrDefault();
        }

        public Imposto BuscaPorNome(string nomeImposto)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Imposto>()
                            .Include(imp => imp.TipoImposto)
                            .Where(imp => imp.Nome == nomeImposto)
                            .FirstOrDefault();
        }
    }
}
