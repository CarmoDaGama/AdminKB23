using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AdminKB.Aplicacoes
{
    public class TurnoApp : AppBase<Turno>
    {
        public TurnoApp() : base(true)
        {
            ActualizarTotaisNoTurnoAberto();
        }
        protected override void InicializaTabela()
        {
            new CaixaApp();
            //Adicionar(new Turno()
            //{
            //    CaixaId = 1,
            //    UsuarioId = 1, 
            //    DataAbertura = DateTime.Now,
            //    DataConfirmacao = DateTime.Now,
            //    DataFecho = DateTime.Now,
            //    Estado = true            
            //});
            base.InicializaTabela();
        }
        private void ActualizarTotaisNoTurnoAberto()
        {
            var turnoAberto = RetornaTurnoActual();
            if (!(turnoAberto is null))
            {
                turnoAberto.SaldoVendas = RetornaSaldoVendas(turnoAberto.TurnoId);
                turnoAberto.SaldoTotalNoCaixa = RetornaSaldoCaixa(turnoAberto.TurnoId);
                Actualizar(turnoAberto);
            }
        }

        public List<Turno> RetornaTurnos(int usuarioId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var list = contexto.Set<Turno>()
                                  .Include(t => t.Usuario)
                                  .Include(t => t.Usuario.Acesso)
                                  .Include(t => t.Caixa)
                                  .Where(t => t.UsuarioId == usuarioId)
                                  .ToList();

                return list;
            }
        }
        public List<Turno> RetornaTurnos(int usuarioId, DateTime dataInicio, DateTime dataFim)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var list = contexto.Set<Turno>()
                                  .Include(t => t.Usuario)
                                  .Include(t => t.Usuario.Acesso)
                                  .Include(t => t.Caixa)
                                  .Where(t => t.UsuarioId == usuarioId && t.DataAbertura >= dataInicio && t.DataAbertura <= dataFim)
                                  .ToList();

                return list;
            }
        }

        public Turno RetornaTurnoPorId(int turnoId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var list = contexto.Set<Turno>()
                               .Include(t => t.Usuario)
                               .Include(t => t.Usuario.Acesso)
                               .Include(t => t.Caixa)
                               .Where(t => t.TurnoId == turnoId)
                               .ToList();
                return list.FirstOrDefault();
            }
        }

        private decimal RetornaSaldoVendas(int turnoId)
        {
            var pagamentosPorTurno = new PagamentoApp().RetornaPagamentosPorTurnoId(turnoId);
            var totalCredito = pagamentosPorTurno.Where(p =>p.MovFin == MovFinanceiro.Credito).Sum(p => p.Total);
            var totalDebito = pagamentosPorTurno.Where(p => p.MovFin == MovFinanceiro.Debito).Sum(p => p.Total);

            return totalCredito - totalDebito;
        }
        private decimal RetornaSaldoCaixa(int turnoId)
        {
            var formaPagamentosEfectuadas = new FormaPagaApp().RetornaFormaPagamentosEfectuadasPorTurnoId(turnoId);
            return formaPagamentosEfectuadas
                                     .Where(fp => fp.FormaPagamento.Descricao == Globais.MetodoPagamentoPadrao)
                                     .Sum(fp => fp.Valor);
        }


        public Turno RetornaTurnoAbertoPorUsuarioId(int usuarioId)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var list = contexto.Set<Turno>()
                               .Include(t => t.Usuario)
                               .Include(t => t.Usuario.Acesso)
                               .Include(t => t.Caixa)
                               .Where(t => t.UsuarioId == usuarioId && t.Estado)
                               .ToList();
                return list.FirstOrDefault();
            }
        }

        public Turno RetornaTurnoActual()
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro())) { 
                var turnoActual = contexto.Set<Turno>()
                               .Include(t => t.Caixa)
                               .Include(t => t.Usuario)
                               .Include(t => t.Usuario.Acesso)
                               .Where(t => t.UsuarioId == Globais.UsuarioIdActual && t.Estado)
                               .FirstOrDefault();
                return turnoActual;
            }
        }
        public new Turno Adicionar(Turno turno)
        {
            base.Adicionar(turno);
            return RetornaTurnoPorId(BuscaUltimaTipoEntidade().TurnoId);
        }
    }
}
