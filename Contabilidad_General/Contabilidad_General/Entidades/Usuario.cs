using System;
namespace Contabilidad_General.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private String usuario;
        private String pwd;
        private DateTime fechaCreacion;
        private int activo;
        private String idEmpleado;
        private String id_empresa;

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Usuario_ { get => usuario; set => usuario = value; }
        public String Pwd { get => pwd; set => pwd = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        private int Activo { get => activo; set => activo = value; }
        private String IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        private String Id_empresa { get => id_empresa; set => id_empresa = value; }


        public Usuario()
        {
        }
    }
}
