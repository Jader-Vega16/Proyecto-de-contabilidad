using System;
namespace Contabilidad_General
{
    public partial class Control_de_Periodos_Contables : Gtk.Window
    {
        public Control_de_Periodos_Contables() :
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
