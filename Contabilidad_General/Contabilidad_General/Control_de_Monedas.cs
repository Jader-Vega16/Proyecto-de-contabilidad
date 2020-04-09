using System;
namespace Contabilidad_General
{
    public partial class Control_de_Monedas : Gtk.Window
    {
        public Control_de_Monedas() :
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
