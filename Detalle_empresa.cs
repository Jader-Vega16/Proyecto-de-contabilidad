using System;
namespace Application
{
    public class Detalle_empresa
    {

        private string id_empresa;
        private string nombre_empresa;
        private string nombre_comercial;
        private string direccion_empresa;
        private string localidad_empresa;
        private string correo_empresa;
        private int activo;

        public string Id_empresa { get => id_empresa; set => id_empresa = value; }
        public string Nombre_empresa { get => nombre_empresa; set => nombre_empresa = value; }
        public string Nombre_comercial { get => nombre_comercial; set => nombre_comercial = value; }
        public string Direccion_empresa { get => direccion_empresa; set => direccion_empresa = value; }
        public string Localidad_empresa { get => localidad_empresa; set => localidad_empresa = value; }
        public string Correo_empresa { get => correo_empresa; set => correo_empresa = value; }
        public string Activo { get => Activo; set => activo = value; }


        public Detalle_empresa()
        {
        }
    }
}
