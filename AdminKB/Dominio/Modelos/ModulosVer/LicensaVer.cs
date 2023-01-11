using FoxLearn.License;

namespace Dominio.Modelos.ModulosVer
{
    public class LicensaVer : Licenca
    {
        public string Periodo 
        { 
            get 
            {
                if (TipoLicensa == LicenseType.TRIAL)
                {
                    var dias = (DataTermino - DataInicio ).Days;
                    return dias +  (dias <= 1?  " DIA" : " DIAS");
                }
                return "ILIMITADO";
            } 
        }
        public string EstadoVer
        {
            get
            {
                return Estado ? "ACTIVA" : "INACTIVA";
            }
        }
    }
}
