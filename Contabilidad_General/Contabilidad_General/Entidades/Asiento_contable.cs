using System;
namespace Contabilidad_General.Entidades
{
    public class Asiento_contable
    {
        private int idAsiento;
        private int codigoAsiento;
        private String cuentaDebeID;
        private float importeDebe;
        private String cuentaHaberID;
        private float importeHaber;
        private int activo;
        private DateTime fecha_asiento;
        private int idCatalogo_cuentas;
        private int idUsuario;
        private String id_empresa;

        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int CodigoAsiento { get => codigoAsiento; set => codigoAsiento = value; }
        public String CuentaDebeID { get => cuentaDebeID; set => cuentaDebeID = value; }
        public float ImporteDebe { get => importeDebe; set => importeDebe = value; }
        public String CuentaHaberID { get => cuentaHaberID; set => cuentaHaberID = value; }
        public float ImporteHaber { get => importeHaber; set => importeHaber = value; }
        public int Activo { get => activo; set => activo = value; }
        public DateTime Fecha_asiento { get => fecha_asiento; set => fecha_asiento = value; }
        public int IdCatalogo_cuentas { get => idCatalogo_cuentas; set => idCatalogo_cuentas = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String Id_empresa { get => id_empresa; set => id_empresa = value; }

        public Asiento_contable()
        {
        }
    }
}
