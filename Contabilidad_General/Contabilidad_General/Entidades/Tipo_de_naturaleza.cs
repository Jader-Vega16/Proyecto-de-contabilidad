using System;
namespace Contabilidad_General.Entidades
{
    public class Tipo_de_naturaleza
    {
        private int id_naturalezaCuenta;
        private String nombreNaturaleza;
        private String descripcion_naturaleza;
        private int activo;
        private int idUsuario;
        private String id_empresa;

        public int Id_naturalezaCuenta { get => id_naturalezaCuenta; set => id_naturalezaCuenta = value; }
        public String NombreNaturaleza { get => nombreNaturaleza; set => nombreNaturaleza = value; }
        public String Descripcion_naturaleza { get => descripcion_naturaleza; set => descripcion_naturaleza = value; }
        public int Activo { get => activo; set => activo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public String Id_empresa { get => id_empresa; set => id_empresa = value; }

        public Tipo_de_naturaleza()
        {
        }
    }
}
