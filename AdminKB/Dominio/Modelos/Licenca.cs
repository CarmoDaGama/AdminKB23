using FoxLearn.License;
using AdminKB.Dominio.Enumerados;
using System;

namespace AdminKB.Dominio.Modelos
{
    public class Licenca
    {
        public int LicencaId { get; set; }
        public LicenseType TipoLicensa { get; set; }
        public TipoModuloLicensa Modulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public bool Estado { get; set; }
        public string Chave { get; set; }
        public string FicheiroLicensa { get; set; }
        public string CaminhoLicensa { get; set; }
        public string Nome { get; set; }
    }
}
