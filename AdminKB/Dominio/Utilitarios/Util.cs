using DevExpress.XtraGrid.Views.Grid;
using Dominio.Enumerados;
using Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Dominio.Utilitarios
{
    public static class Util
    {
        public static string ImpressoraPadrao { get; set; } = "Impressora Padrão";

        public static string BuscaConexaoPadrao()
        {
            var path = string.Format(@"{0}\TextoConexao.txt", Application.StartupPath);
            if (!File.Exists(path))
            {
                Ficheiro.SalvaFicheiro(path, Globais.StringConexaoPadrao);
            }
            var textoConexao = Ficheiro.LerTextoArquivo(path);
            return textoConexao;
        }
        public static string ConverterFicheiroBase64(string caminhoDoFichiero)
        {
            byte[] fichiero = File.ReadAllBytes(caminhoDoFichiero);
            string ficheiroBase64 = Convert.ToBase64String(fichiero);

            return ficheiroBase64;
        }

        public static EstadoImpressao VerMudarEstadoImpresao(EstadoImpressao estadoImpressao)
        {
            switch (estadoImpressao)
            {
                case EstadoImpressao.NaoImprimido:
                    return EstadoImpressao.Original;
                case EstadoImpressao.Original:
                    return EstadoImpressao.Duplicado;
                case EstadoImpressao.Duplicado:
                    return EstadoImpressao.Duplicado;
                default:
                    return EstadoImpressao.Duplicado;
            }
        }

        public static int RetornaIdNaGrade(GridView grid, string colunaFieldName)
        {
            var indice = grid.GetSelectedRows()[0];
            return Convert.ToInt32(grid.GetRowCellValue(indice, colunaFieldName));
        }

        public static void ExecutarMetodoNoutraThread(Control control, Action metodo)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(delegate {
                    metodo.Invoke();
                }));
            }
            else
            {
                metodo.Invoke();
            }
        }

        public static bool UsuarioForAdministrador()
        {
            return Globais.UsuarioActual.Acesso.Nome == Globais.NomeAcessoAdmin;
        }

        public static byte[] ConverterFicheiroBase64ParaByte(string ficheiroBase64)
        {
            byte[] ficheiroEmByte = Convert.FromBase64String(ficheiroBase64);
            return ficheiroEmByte;
        }

        public static void ExecutaComandoCMD(params string[] comandos)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true; // Não preciso
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();
            foreach (var item in comandos)
            {
                cmd.StandardInput.WriteLine(item);
            }
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }
        public static void ShowFormInPanel<Type>(ControlCollection panelControls, Type form)
        {
            panelControls.Clear();
            form.GetType().GetProperty("TopLevel").SetValue(form, false);
            panelControls.GetType().GetMethod("Add").Invoke(panelControls, new object[] { form });
            panelControls[0].Show();
            //Thread.Sleep(1000);
            form.GetType().GetProperty("Dock").SetValue(form, DockStyle.Fill);

        }

        // O método EscreverExtenso recebe um valor do tipo decimal
        public static string EscreverExtenso(decimal valor)
        {
            if (valor <= 0 | valor >= 1000000000000000)
                return "Valor não suportado pelo sistema.";
            else
            {
                string strValor = valor.ToString("000000000000000.00");
                string valor_por_extenso = string.Empty;
                for (int i = 0; i <= 15; i += 3)
                {
                    valor_por_extenso += Escrever_Valor_Extenso(Convert.ToDecimal(strValor.Substring(i, 3)));
                    if (i == 0 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(0, 3)) == 1)
                            valor_por_extenso += " TRILHÃO" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(0, 3)) > 1)
                            valor_por_extenso += " TRILHÕES" + ((Convert.ToDecimal(strValor.Substring(3, 12)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 3 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(3, 3)) == 1)
                            valor_por_extenso += " BILHÃO" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(3, 3)) > 1)
                            valor_por_extenso += " BILHÕES" + ((Convert.ToDecimal(strValor.Substring(6, 9)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 6 & valor_por_extenso != string.Empty)
                    {
                        if (Convert.ToInt32(strValor.Substring(6, 3)) == 1)
                            valor_por_extenso += " MILHÃO" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                        else if (Convert.ToInt32(strValor.Substring(6, 3)) > 1)
                            valor_por_extenso += " MILHÕES" + ((Convert.ToDecimal(strValor.Substring(9, 6)) > 0) ? " E " : string.Empty);
                    }
                    else if (i == 9 & valor_por_extenso != string.Empty)
                        if (Convert.ToInt32(strValor.Substring(9, 3)) > 0)
                            valor_por_extenso += " MIL" + ((Convert.ToDecimal(strValor.Substring(12, 3)) > 0) ? " E " : string.Empty);
                    if (i == 12)
                    {
                        if (valor_por_extenso.Length > 8)
                            if (valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "BILHÃO" | valor_por_extenso.Substring(valor_por_extenso.Length - 6, 6) == "MILHÃO")
                                valor_por_extenso += " DE";
                            else
                                if (valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "BILHÕES" | valor_por_extenso.Substring(valor_por_extenso.Length - 7, 7) == "MILHÕES"
                                    | valor_por_extenso.Substring(valor_por_extenso.Length - 8, 7) == "TRILHÕES")
                                valor_por_extenso += " DE";
                            else
                                    if (valor_por_extenso.Substring(valor_por_extenso.Length - 8, 8) == "TRILHÕES")
                                valor_por_extenso += " DE";
                        if (Convert.ToInt64(strValor.Substring(0, 15)) == 1)
                            valor_por_extenso += " " + Globais.MoedaActual.ToString().ToUpper();
                        else if (Convert.ToInt64(strValor.Substring(0, 15)) > 1)
                            valor_por_extenso += " " + Globais.MoedaActual.ToString().ToUpper();
                        if (Convert.ToInt32(strValor.Substring(16, 2)) > 0 && valor_por_extenso != string.Empty)
                            valor_por_extenso += " E ";
                    }
                    if (i == 15)
                        if (Convert.ToInt32(strValor.Substring(16, 2)) == 1)
                            valor_por_extenso += " CENTAVO";
                        else if (Convert.ToInt32(strValor.Substring(16, 2)) > 1)
                            valor_por_extenso += " CENTAVOS";
                }
                return valor_por_extenso;
            }
        }
        private static string Escrever_Valor_Extenso(decimal valor)
        {
            if (valor <= 0)
                return string.Empty;
            else
            {
                string montagem = string.Empty;
                if (valor > 0 & valor < 1)
                {
                    valor *= 100;
                }
                string strValor = valor.ToString("000");
                int a = Convert.ToInt32(strValor.Substring(0, 1));
                int b = Convert.ToInt32(strValor.Substring(1, 1));
                int c = Convert.ToInt32(strValor.Substring(2, 1));
                if (a == 1) montagem += (b + c == 0) ? "CEM" : "CENTO";
                else if (a == 2) montagem += "DUZENTOS";
                else if (a == 3) montagem += "TREZENTOS";
                else if (a == 4) montagem += "QUATROCENTOS";
                else if (a == 5) montagem += "QUINHENTOS";
                else if (a == 6) montagem += "SEISCENTOS";
                else if (a == 7) montagem += "SETECENTOS";
                else if (a == 8) montagem += "OITOCENTOS";
                else if (a == 9) montagem += "NOVECENTOS";
                if (b == 1)
                {
                    if (c == 0) montagem += ((a > 0) ? " E " : string.Empty) + "DEZ";
                    else if (c == 1) montagem += ((a > 0) ? " E " : string.Empty) + "ONZE";
                    else if (c == 2) montagem += ((a > 0) ? " E " : string.Empty) + "DOZE";
                    else if (c == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TREZE";
                    else if (c == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUATORZE";
                    else if (c == 5) montagem += ((a > 0) ? " E " : string.Empty) + "QUINZE";
                    else if (c == 6) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSEIS";
                    else if (c == 7) montagem += ((a > 0) ? " E " : string.Empty) + "DEZESSETE";
                    else if (c == 8) montagem += ((a > 0) ? " E " : string.Empty) + "DEZOITO";
                    else if (c == 9) montagem += ((a > 0) ? " E " : string.Empty) + "DEZENOVE";
                }
                else if (b == 2) montagem += ((a > 0) ? " E " : string.Empty) + "VINTE";
                else if (b == 3) montagem += ((a > 0) ? " E " : string.Empty) + "TRINTA";
                else if (b == 4) montagem += ((a > 0) ? " E " : string.Empty) + "QUARENTA";
                else if (b == 5) montagem += ((a > 0) ? " E " : string.Empty) + "CINQUENTA";
                else if (b == 6) montagem += ((a > 0) ? " E " : string.Empty) + "SESSENTA";
                else if (b == 7) montagem += ((a > 0) ? " E " : string.Empty) + "SETENTA";
                else if (b == 8) montagem += ((a > 0) ? " E " : string.Empty) + "OITENTA";
                else if (b == 9) montagem += ((a > 0) ? " E " : string.Empty) + "NOVENTA";
                if (strValor.Substring(1, 1) != "1" & c != 0 & montagem != string.Empty) montagem += " E ";
                if (strValor.Substring(1, 1) != "1")
                    if (c == 1) montagem += "UM";
                    else if (c == 2) montagem += "DOIS";
                    else if (c == 3) montagem += "TRÊS";
                    else if (c == 4) montagem += "QUATRO";
                    else if (c == 5) montagem += "CINCO";
                    else if (c == 6) montagem += "SEIS";
                    else if (c == 7) montagem += "SETE";
                    else if (c == 8) montagem += "OITO";
                    else if (c == 9) montagem += "NOVE";
                return montagem;
            }
        }

        public static bool ObjectoNulo(object objecto)
        {
            return objecto is null;
        }

        public static void ShowFormInPanel<Type>(ControlCollection panelControls, Type form, Panel panelShadow)
        {
            panelControls.Clear();
            panelControls.Add(panelShadow);
            form.GetType().GetProperty("TopLevel").SetValue(form, false);
            panelControls.GetType().GetMethod("Add").Invoke(panelControls, new object[] { form });
            panelControls[0].Show();
            //Thread.Sleep(1000);
            form.GetType().GetProperty("Dock").SetValue(form, DockStyle.Fill);

        }

        public static bool ListaNula<Tabela>(List<Tabela> entities) where Tabela : class, new()
        {
            return (entities is null) || entities.Count <= 0;
        }
        public static string MostrarValorNaMoedaActual(decimal valor)
        {
            return valor.ToString("N2") + " " + BuscaSiglaDaMoeda(Globais.MoedaActual);
        }

        public static string BuscaSiglaDaMoeda(TipoMoeda moedaActual)
        {
            switch (moedaActual)
            {
                case TipoMoeda.Kwanza:
                    return "AKZ";
                case TipoMoeda.Dolar:
                    return "$";
                case TipoMoeda.Euro:
                    return "€";
                default:
                    return "AKZ";
            }
        }

        public static DateTime RetornaDataVencime(int Dias)
        {
            return DateTime.Now.AddDays(Dias);
        }

        public static decimal CalculaRetornaValorPercentual(decimal valor, decimal percentagem)
        {
            return valor * (percentagem / 100);
        }

        public static decimal CalcularTotalProdutoMov(ProdutoMovimentacao produtoMovimentacao)
        {
            var valorImposto = CalcularValorImpostoArtigo(produtoMovimentacao);
            var valorDesc = CalcularValorDescontoArtigo(produtoMovimentacao);
            var valorRetencao = CalcularValorRetencaoArtigo(produtoMovimentacao);
            var total = (produtoMovimentacao.Preco + valorImposto - valorDesc + valorRetencao) * produtoMovimentacao.Quantidade;

            return total;
        }

        public static decimal CalcularValorRetencaoArtigo(ProdutoMovimentacao produtoMovimentacao)
        {
            var RetenResult = 0.0m;

            RetenResult = produtoMovimentacao.Preco * (produtoMovimentacao.Retencao / 100);

            return RetenResult;
        }

        public static decimal CalcularValorDescontoArtigo(ProdutoMovimentacao produtoMovimentacao)
        {
            var descResult = 0.0m;

            descResult = produtoMovimentacao.Preco * (produtoMovimentacao.DescontoPercentagem / 100) + 
                         produtoMovimentacao.Preco * (produtoMovimentacao.Documento.DescontoGlobal / 100);

            return descResult;
        }

        public static string RetornaStringDigitos(int numeroOrdem, int qtdDigitos)
        {
            var strNum = numeroOrdem.ToString();

            if (strNum.Length == qtdDigitos)
            {
                return strNum;
            }
            else
            {
                int qtdFalta = qtdDigitos - strNum.Length;
                for (int i = 0; i < qtdFalta; i++)
                {
                    strNum = "0" + strNum;
                }
                return strNum;
            }
        }

        public static decimal CalcularValorImpostoArtigo(ProdutoMovimentacao produtoMovimentacao)
        {
            var impostoResult = 0.0m;

            impostoResult = produtoMovimentacao.Preco * (produtoMovimentacao.ProdutoEstoque.Produto.Imposto.Percentagem / 100);

            return impostoResult;
        }
        public static DateTime RetornaDataFormatoCorreto(DateTime data, string strHora)
        {
            int hora = 0, minuno = 0, segundo = 0;
            var spHora = strHora.Split(':');
            if (!Equals(spHora, null) && spHora.Length > 1)
            {
                hora = int.Parse(spHora[0]);
                minuno = int.Parse(spHora[1]);
            }
            segundo = data.Second;
            return new DateTime(data.Year, data.Month, data.Day, hora, minuno, segundo);
        }
        public static string RetornaSiglaTipoConta(string tipoConta)
        {
            switch (tipoConta)
            {
                case "Conta de 1.º grau da contabilidade geral":
                    return "GR";

                case "Conta agregada ou integrada da contabilidade geral":
                    return "GA";

                case "Conta de 1.º grau da contabilidade analítica":
                    return "AR";

                case "Conta agregada ou integrada da contabilidade analítica":
                    return "AA";

                case "Conta de movimento da contabilidade analítica":
                    return "AM";

                default:
                    return "Desconhecido";
            }
        }

        public static decimal CalcularTotaIliquidoProdutoMov(ProdutoMovimentacao produtoMovimentacao)
        {
            var valorDesc = CalcularValorDescontoArtigo(produtoMovimentacao);
            var valorRetencao = CalcularValorRetencaoArtigo(produtoMovimentacao);
            var totalIliquido = (produtoMovimentacao.Preco - valorDesc + valorRetencao) * produtoMovimentacao.Quantidade;

            return totalIliquido;
        }
    }
}
