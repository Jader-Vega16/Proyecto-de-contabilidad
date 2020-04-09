using System;
namespace Contabilidad_General.Entidades
{
    public class Rol_opcion
    {
        private int idRolOpc;
        private String habilitado;
        private DateTime fechaCreacion;
        private int idRol;
        private int idOpciones;

        public int IdRolOpc { get => idRolOpc; set => idRolOpc = value; }
        public String Habilitado { get => habilitado; set => habilitado = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public int IdOpciones { get => idOpciones; set => idOpciones = value; }

        public Rol_opcion()
        {
        }
    }
}
