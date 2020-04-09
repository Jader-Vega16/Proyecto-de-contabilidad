using System;
namespace Contabilidad_General.Entidades
{
    public class Usuario_con_rol
    {
        private int idusuario_rol;
        private DateTime fechaCreacion;
        private int idUsuario;
        private int idRol;

        public int Idusurio_rol { get => idusuario_rol; set => idusuario_rol = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public Usuario_con_rol()
        {
        }
    }
}
