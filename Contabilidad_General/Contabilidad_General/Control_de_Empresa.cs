using System;
namespace Contabilidad_General
{
    public partial class Control_de_Empresa : Gtk.Window
    {
        public Control_de_Empresa() :
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
