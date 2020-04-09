using System;
namespace Contabilidad_General.Entidades
{
    public class Periodo_contable
    {
        private int idPeriodos_contables;
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private int activo;
        private String id_empresa;
        private int idUsuario;

        public int IdPeriodos_contables { get => idPeriodos_contables; set => idPeriodos_contables = value; }
        public DateTime Fecha_inicio { get => fecha_inicio; set => fecha_inicio = value; }
        public DateTime Fecha_fin { get => fecha_fin; set => fecha_fin = value; }
        public int Activo { get => activo; set => activo = value; }
        public  String Id_empresa { get => id_empresa; set => id_empresa = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public Periodo_contable()
        {
        }
    }
}
