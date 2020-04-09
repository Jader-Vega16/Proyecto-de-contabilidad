using System;
namespace Contabilidad_General
{
    public partial class Control_de_Empleados : Gtk.Window
    {
        public Control_de_Empleados() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnBtnSalirClicked(object sender, EventArgs e)
        {
            this.Destroy();
        }
    }
}
