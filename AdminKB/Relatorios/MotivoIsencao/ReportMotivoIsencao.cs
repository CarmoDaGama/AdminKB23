using DevExpress.XtraReports.UI;
using AdminKB.Dominio.Enumerados;
using AdminKB.Dominio.Modelos;
using AdminKB.Dominio.Modelos.ModulosVer;
using AdminKB.Dominio.Utilitarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace AdminKB.Relatorios.MotivoIsencao
{
    public partial class ReportMotivoIsencao : XtraReport
    {
        public ReportMotivoIsencao(List<ProdutoMovimentacao> produtoMovimentacaos)
        {
            InitializeComponent();
            var motivos = CarregarMotivos(produtoMovimentacaos);
            //ConverterParaDolar(motivos);
            objectDataSource1.DataSource = motivos;
        }

        private void ConverterParaDolar(List<MotivoIsencaoVer> motivos)
        {
            if (Globais.MoedaActual == TipoMoeda.Dolar)
            {
                foreach (var motivo in motivos)
                {
                    motivo.QtdIncidencia = ConversorDeMoedasCambias.DeKwzParaDolar(motivo.QtdIncidencia);
                    motivo.TotalImposto = ConversorDeMoedasCambias.DeKwzParaDolar(motivo.TotalImposto);
                }
            }
        }

        private List<MotivoIsencaoVer> CarregarMotivos(List<ProdutoMovimentacao> produtoMovimentacaos)
        {
            var motivos = new List<MotivoIsencaoVer>();
            foreach (var produto in produtoMovimentacaos)
            {
                var produtoRegist = produto.ProdutoEstoque.Produto;
                var oldMotivo = motivos.Where(m => m.TaxaValor == produtoRegist.Imposto.Percentagem ||
                m.Motivo == produtoRegist.MotivoIsencao.Nome).FirstOrDefault();
                if (Equals(oldMotivo, null))
                {
                    motivos.Add(new MotivoIsencaoVer()
                    {
                        TaxaValor = produtoRegist.Imposto.Percentagem,
                        QtdIncidencia = produto.Preco * produto.Quantidade,
                        TotalImposto = produto.Imposto * produto.Quantidade,
                        Motivo = produto.ProdutoEstoque.Produto.MotivoIsencao.Nome
                    });
                }
                else
                {
                    oldMotivo.QtdIncidencia += produto.Preco * produto.Quantidade;
                    oldMotivo.TotalImposto += produto.Imposto * produto.Quantidade;
                }
            }
            return motivos;
        }
    }
}
