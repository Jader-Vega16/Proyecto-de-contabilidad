using System;
namespace Contabilidad_General.Entidades
{
    public class Catalogo_de_cuenta
    {
        private int idCatalogo_cuentas;
        private String id_cuenta;
        private String numero_cuenta;
        private String nombre_cuenta;
        private String descripcion_cuenta;
        private int activo;
        private String pais_cuenta;
        private String id_cuentaPadre;
        private String id_empresa;
        private int id_naturalezaCuenta;
        private int idUsuario;

        public int IdCatalogo_cuentas { get => idCatalogo_cuentas; set => idCatalogo_cuentas = value; }
        public String Id_cuenta { get => id_cuenta; set => id_cuenta = value; }
        public String Numero_cuenta { get => numero_cuenta; set => numero_cuenta = value; }
        public String Nombre_cuenta { get => nombre_cuenta; set => nombre_cuenta = value; }
        public String Descripcion_cuenta { get => descripcion_cuenta; set => descripcion_cuenta = value; }
        private int Activo { get => activo; set => activo = value; }
        public String Pais_cuenta { get => pais_cuenta; set => pais_cuenta = value; }
        public String Id_cuentaPadre { get => id_cuentaPadre; set => id_cuentaPadre = value; }
        public String Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int Id_naturalezaCuenta { get => id_naturalezaCuenta; set => id_naturalezaCuenta = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }


        public Catalogo_de_cuenta()
        {
        }
    }
}
