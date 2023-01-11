using FoxLearn.License;
using Dominio.Enumerados;
using Dominio.Modelos;
using Dominio.Modelos.ModulosVer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminKB.Aplicacoes
{
    public class LicencaApp : AppBase<Licenca>
    {
        public LicencaApp():base(true)
        {
            DesactivarLicencasExpiradas();
        }

        private void DesactivarLicencasExpiradas()
        {
            var licencas = BuscaTodosRegistros();
            foreach (var item in licencas)
            {
                if (item.Estado == true && item.DataTermino < DateTime.Now)
                {
                    item.Estado = false;
                    Actualizar(item);
                }
            }
        }

        public List<LicensaVer> BuscaLicensas()
        {
            var licensasVer = new List<LicensaVer>();
            var licensa = BuscaTodosRegistros();
            foreach (var item in licensa)
            {
                licensasVer.Add(new LicensaVer()
                {
                    DataInicio = item.DataInicio,
                    DataTermino = item.DataTermino, 
                    Estado = item.Estado, 
                    LicencaId = item.LicencaId, 
                    Modulo = item.Modulo, 
                    TipoLicensa = item.TipoLicensa
                });
            }
            return licensasVer;
        }
        protected override void InicializaTabela()
        {
            //Add(new Licenca()
            //{
            //    DataInicio = DateTime.Now,
            //    DataTermino = DateTime.Now,
            //    Estado = true,
            //    Modulo = TipoModuloLicensa.Facturação,
            //    TipoLicensa = LicenseType.FULL
            //});
            //Add(new Licenca()
            //{
            //    DataInicio = DateTime.Now,
            //    DataTermino = DateTime.Now,
            //    Estado = true,
            //    Modulo = TipoModuloLicensa.Escolar,
            //    TipoLicensa = LicenseType.FULL
            //});
            //Add(new Licenca()
            //{
            //    DataInicio = DateTime.Now,
            //    DataTermino = DateTime.Now.Subtract(new TimeSpan(90, 0, 0)),
            //    Estado = true,
            //    Modulo = TipoModuloLicensa.Financeiro,
            //    TipoLicensa = LicenseType.TRIAL
            //});
            base.InicializaTabela();
        }
        public bool GravarLicensa(Licenca licenca)
        {
            if (PodeGravar(licenca.Chave))
            {
                KeyManager keyManager = new KeyManager(ComputerInfo.GetComputerId());
                string chaveProduto = licenca.Chave;
                if (keyManager.ValidKey(ref chaveProduto))
                {
                    KeyValuesClass keyValuesClass = new KeyValuesClass();
                    if (keyManager.DisassembleKey(chaveProduto, ref keyValuesClass))
                    {
                        var licencaInfo = InicieLicencaInfo(keyValuesClass, licenca, chaveProduto);
                        Gravar(keyManager, licenca, licencaInfo, keyValuesClass);
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
            }
            return false;
        }

        private void Gravar(KeyManager keyManager, 
            Licenca licenca, 
            LicenseInfo licencaInfo, 
            KeyValuesClass keyValuesClass)
        {
            keyManager.SaveSuretyFile(licenca.CaminhoLicensa, licencaInfo);
            licenca.Modulo = EscolherModulo(keyValuesClass.ProductCode);
            licenca.DataInicio = DateTime.Now;
            licenca.TipoLicensa = keyValuesClass.Type;
            if (licenca.TipoLicensa == LicenseType.FULL)
            {
                licenca.DataTermino = DateTime.Now.AddYears(100);
            }
            else
            {
                licenca.DataTermino = keyValuesClass.Expiration;
            }
            licenca.Estado = true;
            Adicionar(licenca);
        }
        public bool ExisteLicencaActiva()
        {
            var licencas = BuscaTodosRegistros();

            return true;/*!Equals(null, licencas) && licencas.Where(lc => lc.Estado == true).FirstOrDefault() != null;*/
        }
        private KeyValuesClass BuscaKeyValusClass(string caminhoLicensa)
        {
            KeyManager keyManager = new KeyManager(ComputerInfo.GetComputerId());
            LicenseInfo license = new LicenseInfo();
            int value = keyManager.LoadSuretyFile(string.Format(caminhoLicensa, Application.StartupPath), ref license);
            string productKey = license.ProductKey;
            if (keyManager.ValidKey(ref productKey))
            {
                KeyValuesClass keyValues = new KeyValuesClass();
                if (keyManager.DisassembleKey(productKey, ref keyValues))
                {
                    return keyValues;
                }
                return null;
            }
            return null;
        }

        private bool ModuloJaExiste(TipoModuloLicensa tipoModuloLicensa)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Licenca>().Where(lc => lc.Modulo == tipoModuloLicensa).FirstOrDefault() != null;
        }

        private LicenseInfo InicieLicencaInfo(KeyValuesClass keyValuesClass, Licenca licenca, string chaveProduto)
        {
            LicenseInfo licencaInfo = new LicenseInfo();
            licencaInfo.ProductKey = chaveProduto;
            licenca.Nome = "KSoft";
            licencaInfo.FullName = licenca.Nome;
            if (keyValuesClass.Type == LicenseType.TRIAL)
            {
                licencaInfo.Day = keyValuesClass.Expiration.Day;
                licencaInfo.Month = keyValuesClass.Expiration.Month;
                licencaInfo.Year = keyValuesClass.Expiration.Year;
            }
            return licencaInfo;
        }

        private bool PodeGravar(string chave)
        {
            if (LicencaExiste(chave))
            {
                return false;
            }
            return true;
        }

        private bool LicencaExiste(string chave)
        {
            return BuscaLicensaPorChave(chave) != null;
        }

        private TipoModuloLicensa EscolherModulo(byte productCode)
        {
            return (TipoModuloLicensa)productCode;
        }
        public  Licenca BuscaLicensaPorChave(string chave)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Licenca>().Where(lc => lc.Chave == chave).FirstOrDefault();
        }
        public  Licenca BuscaLicensaPorModulo(TipoModuloLicensa moduloLicensa)
        {
            using (var contexto = Iniciar_Contexto(LerConexaoNoFicheiro()))
                return contexto.Set<Licenca>().Where(lc => lc.Modulo == moduloLicensa).FirstOrDefault();
        }
        public bool LicencaValida(string chaveLicenca)
        {
            return LicencaValida(BuscaLicensaPorChave(chaveLicenca));
        }
        public bool LicencaValida(Licenca licensa)
        {
            var productID = ComputerInfo.GetComputerId();
            KeyManager keyManager = new KeyManager(productID);
            LicenseInfo license = new LicenseInfo();
            int value = keyManager.LoadSuretyFile(string.Format(licensa.CaminhoLicensa, Application.StartupPath), ref license);
            string productKey = license.ProductKey;
            if (keyManager.ValidKey(ref productKey))
            {
                KeyValuesClass keyValues = new KeyValuesClass();
                if (keyManager.DisassembleKey(productKey, ref keyValues))
                {
                    return (DateTime.Now - keyValues.Expiration).Days > 0;
                }
                return false;
            }
            return false;
        }
    }
}
