using System;
namespace Contabilidad_General.Entidades
{
    public class Moneda
    {
        private int id_moneda;
        private String nombre_moneda;
        private String codigo_ISO_Alfab;
        private String pais;
        private float tasa_conversion;
        private int activo;
        private int idUsuario;
        private String id_empresa;
         
        public int Id_moneda { get => id_moneda; set => id_moneda = value; }
        public String Nombre_moneda{ get => nombre_moneda; set => nombre_moneda = value; }
        public String Codigo_ISO_Alfab { get => codigo_ISO_Alfab; set => codigo_ISO_Alfab = value; }
        public String Pais { get => pais; set => pais = value; }
        public float Tasa_conversion { get => tasa_conversion; set => tasa_conversion = value; }
        public int Activo { get => activo; set => activo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String Id_empresa { get => id_empresa; set => id_empresa = value; }

        public Moneda()
        {
        }
    }
}
