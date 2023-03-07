using AdminKB.Dominio.Modelos;
using System;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class MotivoIsencaoApp : AppBase<MotivoIsencao>
    {
        public MotivoIsencaoApp() : base(true)
        {

        }
        protected override void InicializaTabela()
        {
            Adicionar(new MotivoIsencao() { Nome = "--", Referencia = "--" });
            Adicionar(new MotivoIsencao() { Nome = "Regime transitório", Referencia = "M00" });
            Adicionar(new MotivoIsencao() { Nome = "Transmissão de bens e serviços não sujeita", Referencia = "M02" });
            Adicionar(new MotivoIsencao() { Nome = "IVA - Regime de não sujeição", Referencia = "M04" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º a) do CIVA", Referencia = "M10" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º b) do CIVA", Referencia = "M11" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º c) do CIVA", Referencia = "M12" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º d) do CIVA", Referencia = "M13" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º e) do CIVA", Referencia = "M14" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º f) do CIVA", Referencia = "M15" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º g) do CIVA", Referencia = "M16" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º h) do CIVA", Referencia = "M17" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º i) do CIVA", Referencia = "M18" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º j) do CIVA", Referencia = "M19" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 12º k) do CIVA", Referencia = "M20" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 a) do CIVA", Referencia = "M30" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 b) do CIVA", Referencia = "M31" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 c) do CIVA", Referencia = "M32" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 d) do CIVA", Referencia = "M33" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 e) do CIVA", Referencia = "M34" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 f) do CIVA", Referencia = "M35" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 g) do CIVA", Referencia = "M36" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 h) do CIVA", Referencia = "M37" });
            Adicionar(new MotivoIsencao() { Nome = "Isento Artigo 15º 1 i) do CIVA", Referencia = "M38" });

            base.InicializaTabela();
        }

        public MotivoIsencao BuscaPorReferencia(string referencia)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<MotivoIsencao>().Where(m=> m.Referencia == referencia).FirstOrDefault();
        }
    }
}
