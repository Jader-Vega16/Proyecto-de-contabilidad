using System;
namespace Contabilidad_General.Entidades
{
    public class Libro_mayor
    {
        private int idLibro_mayor;
        private String id_cuenta;
        private int codigoAsiento;
        private String mes_libro_mayor;
        private String concepto_libro;
        private float totalHaber;
        private float totalDebe;
        private String concepto_movimiento;
        private int activo;
        private int idAsiento;
        private int idUsuario;
        private String id_empresa;
        private int idPeriodos_contables;
        private int idCatalogo_cuentas;

        public int IdLibro_mayor { get => idLibro_mayor; set => idLibro_mayor = value; }
        public String Id_cuenta { get => id_cuenta; set => id_cuenta = value; }
        private int CodigoAsiento { get => codigoAsiento; set => codigoAsiento = value; }
        public String Mes_libro_mayor { get => mes_libro_mayor; set => mes_libro_mayor = value; }
        public String Concepto_libro { get => concepto_libro; set => concepto_libro = value; }
        public float TotalHaber { get => totalHaber; set => totalHaber = value; }
        public float TotaDebe { get => totalDebe; set => totalDebe = value; }
        public String Concepto_movimiento { get => concepto_movimiento; set => concepto_movimiento = value; }
        public int Activo { get => activo; set => activo = value; }
        public int IdAsiento { get => idAsiento; set => idAsiento = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String Id_empresa { get => id_empresa; set => id_empresa = value; }
        private int IdPeriodos_contables { get => idPeriodos_contables; set => idPeriodos_contables = value; }
        public int IdCatalogos_cuentas { get => idCatalogo_cuentas; set => idCatalogo_cuentas = value; }

        public Libro_mayor()
        {
        }
    }
}
