
// This file has been generated by the GUI designer. Do not modify.
namespace Contabilidad_General
{
	public partial class Control_de_Usuarios_con_Rol
	{
		private global::Gtk.VBox vbox34;

		private global::Gtk.HBox hbox32;

		private global::Gtk.Alignment alignment32;

		private global::Gtk.Alignment alignment31;

		private global::Gtk.Button btnSalir;

		private global::Gtk.VBox vbox35;

		private global::Gtk.Label label46;

		private global::Gtk.HBox hbox34;

		private global::Gtk.HBox hbox36;

		private global::Gtk.Label label47;

		private global::Gtk.Entry txtBuscarIDUsuarioRol;

		private global::Gtk.Button btnBuscarIDUsuarioRol;

		private global::Gtk.HBox hbox35;

		private global::Gtk.Label label48;

		private global::Gtk.Entry txtBuscarID;

		private global::Gtk.Button btnBuscarID;

		private global::Gtk.HBox hbox33;

		private global::Gtk.ScrolledWindow scrolledwindow3;

		private global::Gtk.TreeView tvUsuariosRol;

		private global::Gtk.VBox vbox37;

		private global::Gtk.Label label49;

		private global::Gtk.Label label11;

		private global::Gtk.Label label50;

		private global::Gtk.Label label51;

		private global::Gtk.VBox vbox36;

		private global::Gtk.Entry txtIDUsuarioRol;

		private global::Gtk.Entry txtFechaCreacion;

		private global::Gtk.Entry txtIDUsuario;

		private global::Gtk.ComboBox combobox4;

		private global::Gtk.HBox hbox37;

		private global::Gtk.Alignment alignment34;

		private global::Gtk.Alignment alignment33;

		private global::Gtk.HBox hbox38;

		private global::Gtk.Button btnNuevo;

		private global::Gtk.Button btnAgregar;

		private global::Gtk.Button btnEditar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget Contabilidad_General.Control_de_Usuarios_con_Rol
			this.Name = "Contabilidad_General.Control_de_Usuarios_con_Rol";
			this.Title = global::Mono.Unix.Catalog.GetString("Control_de_Usuarios_con_Rol");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child Contabilidad_General.Control_de_Usuarios_con_Rol.Gtk.Container+ContainerChild
			this.vbox34 = new global::Gtk.VBox();
			this.vbox34.Name = "vbox34";
			this.vbox34.Spacing = 6;
			// Container child vbox34.Gtk.Box+BoxChild
			this.hbox32 = new global::Gtk.HBox();
			this.hbox32.Name = "hbox32";
			this.hbox32.Spacing = 6;
			// Container child hbox32.Gtk.Box+BoxChild
			this.alignment32 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment32.Name = "alignment32";
			this.hbox32.Add(this.alignment32);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox32[this.alignment32]));
			w1.Position = 0;
			// Container child hbox32.Gtk.Box+BoxChild
			this.alignment31 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment31.Name = "alignment31";
			this.hbox32.Add(this.alignment31);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox32[this.alignment31]));
			w2.Position = 1;
			// Container child hbox32.Gtk.Box+BoxChild
			this.btnSalir = new global::Gtk.Button();
			this.btnSalir.CanFocus = true;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.UseUnderline = true;
			this.btnSalir.Label = global::Mono.Unix.Catalog.GetString("Salir");
			this.hbox32.Add(this.btnSalir);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox32[this.btnSalir]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox34.Add(this.hbox32);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox34[this.hbox32]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox34.Gtk.Box+BoxChild
			this.vbox35 = new global::Gtk.VBox();
			this.vbox35.Name = "vbox35";
			this.vbox35.Spacing = 6;
			this.vbox35.BorderWidth = ((uint)(6));
			// Container child vbox35.Gtk.Box+BoxChild
			this.label46 = new global::Gtk.Label();
			this.label46.Name = "label46";
			this.label46.LabelProp = global::Mono.Unix.Catalog.GetString("Control de Usuarios con Rol\n");
			this.vbox35.Add(this.label46);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox35[this.label46]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox35.Gtk.Box+BoxChild
			this.hbox34 = new global::Gtk.HBox();
			this.hbox34.Name = "hbox34";
			this.hbox34.Spacing = 6;
			// Container child hbox34.Gtk.Box+BoxChild
			this.hbox36 = new global::Gtk.HBox();
			this.hbox36.Name = "hbox36";
			this.hbox36.Spacing = 6;
			// Container child hbox36.Gtk.Box+BoxChild
			this.label47 = new global::Gtk.Label();
			this.label47.Name = "label47";
			this.label47.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar por  Id del Usuario Rol:");
			this.hbox36.Add(this.label47);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.label47]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox36.Gtk.Box+BoxChild
			this.txtBuscarIDUsuarioRol = new global::Gtk.Entry();
			this.txtBuscarIDUsuarioRol.CanFocus = true;
			this.txtBuscarIDUsuarioRol.Name = "txtBuscarIDUsuarioRol";
			this.txtBuscarIDUsuarioRol.IsEditable = true;
			this.txtBuscarIDUsuarioRol.InvisibleChar = '•';
			this.hbox36.Add(this.txtBuscarIDUsuarioRol);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.txtBuscarIDUsuarioRol]));
			w7.Position = 1;
			// Container child hbox36.Gtk.Box+BoxChild
			this.btnBuscarIDUsuarioRol = new global::Gtk.Button();
			this.btnBuscarIDUsuarioRol.CanFocus = true;
			this.btnBuscarIDUsuarioRol.Name = "btnBuscarIDUsuarioRol";
			this.btnBuscarIDUsuarioRol.UseUnderline = true;
			this.btnBuscarIDUsuarioRol.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox36.Add(this.btnBuscarIDUsuarioRol);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox36[this.btnBuscarIDUsuarioRol]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.hbox34.Add(this.hbox36);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox34[this.hbox36]));
			w9.Position = 0;
			// Container child hbox34.Gtk.Box+BoxChild
			this.hbox35 = new global::Gtk.HBox();
			this.hbox35.Name = "hbox35";
			this.hbox35.Spacing = 6;
			// Container child hbox35.Gtk.Box+BoxChild
			this.label48 = new global::Gtk.Label();
			this.label48.Name = "label48";
			this.label48.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar por Id del Usuario:");
			this.hbox35.Add(this.label48);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.label48]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox35.Gtk.Box+BoxChild
			this.txtBuscarID = new global::Gtk.Entry();
			this.txtBuscarID.CanFocus = true;
			this.txtBuscarID.Name = "txtBuscarID";
			this.txtBuscarID.IsEditable = true;
			this.txtBuscarID.InvisibleChar = '•';
			this.hbox35.Add(this.txtBuscarID);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.txtBuscarID]));
			w11.Position = 1;
			// Container child hbox35.Gtk.Box+BoxChild
			this.btnBuscarID = new global::Gtk.Button();
			this.btnBuscarID.CanFocus = true;
			this.btnBuscarID.Name = "btnBuscarID";
			this.btnBuscarID.UseUnderline = true;
			this.btnBuscarID.Label = global::Mono.Unix.Catalog.GetString("Buscar");
			this.hbox35.Add(this.btnBuscarID);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox35[this.btnBuscarID]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			this.hbox34.Add(this.hbox35);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox34[this.hbox35]));
			w13.Position = 1;
			this.vbox35.Add(this.hbox34);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox35[this.hbox34]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox35.Gtk.Box+BoxChild
			this.hbox33 = new global::Gtk.HBox();
			this.hbox33.Name = "hbox33";
			this.hbox33.Spacing = 6;
			this.hbox33.BorderWidth = ((uint)(6));
			// Container child hbox33.Gtk.Box+BoxChild
			this.scrolledwindow3 = new global::Gtk.ScrolledWindow();
			this.scrolledwindow3.CanFocus = true;
			this.scrolledwindow3.Name = "scrolledwindow3";
			this.scrolledwindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow3.Gtk.Container+ContainerChild
			this.tvUsuariosRol = new global::Gtk.TreeView();
			this.tvUsuariosRol.CanFocus = true;
			this.tvUsuariosRol.Name = "tvUsuariosRol";
			this.scrolledwindow3.Add(this.tvUsuariosRol);
			this.hbox33.Add(this.scrolledwindow3);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox33[this.scrolledwindow3]));
			w16.Position = 0;
			// Container child hbox33.Gtk.Box+BoxChild
			this.vbox37 = new global::Gtk.VBox();
			this.vbox37.Name = "vbox37";
			this.vbox37.Spacing = 6;
			// Container child vbox37.Gtk.Box+BoxChild
			this.label49 = new global::Gtk.Label();
			this.label49.Name = "label49";
			this.label49.Xalign = 1F;
			this.label49.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Usuario  Rol:");
			this.vbox37.Add(this.label49);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox37[this.label49]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			w17.Padding = ((uint)(7));
			// Container child vbox37.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label();
			this.label11.Name = "label11";
			this.label11.Xalign = 1F;
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de Creacion:");
			this.vbox37.Add(this.label11);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox37[this.label11]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox37.Gtk.Box+BoxChild
			this.label50 = new global::Gtk.Label();
			this.label50.Name = "label50";
			this.label50.Xalign = 1F;
			this.label50.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Usuario:");
			this.vbox37.Add(this.label50);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox37[this.label50]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			w19.Padding = ((uint)(12));
			// Container child vbox37.Gtk.Box+BoxChild
			this.label51 = new global::Gtk.Label();
			this.label51.Name = "label51";
			this.label51.Xalign = 1F;
			this.label51.LabelProp = global::Mono.Unix.Catalog.GetString("ID del Rol:");
			this.vbox37.Add(this.label51);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox37[this.label51]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			w20.Padding = ((uint)(6));
			this.hbox33.Add(this.vbox37);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox33[this.vbox37]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox33.Gtk.Box+BoxChild
			this.vbox36 = new global::Gtk.VBox();
			this.vbox36.Name = "vbox36";
			this.vbox36.Spacing = 6;
			// Container child vbox36.Gtk.Box+BoxChild
			this.txtIDUsuarioRol = new global::Gtk.Entry();
			this.txtIDUsuarioRol.CanFocus = true;
			this.txtIDUsuarioRol.Name = "txtIDUsuarioRol";
			this.txtIDUsuarioRol.IsEditable = true;
			this.txtIDUsuarioRol.InvisibleChar = '•';
			this.vbox36.Add(this.txtIDUsuarioRol);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox36[this.txtIDUsuarioRol]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child vbox36.Gtk.Box+BoxChild
			this.txtFechaCreacion = new global::Gtk.Entry();
			this.txtFechaCreacion.CanFocus = true;
			this.txtFechaCreacion.Name = "txtFechaCreacion";
			this.txtFechaCreacion.IsEditable = true;
			this.txtFechaCreacion.InvisibleChar = '•';
			this.vbox36.Add(this.txtFechaCreacion);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox36[this.txtFechaCreacion]));
			w23.Position = 1;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox36.Gtk.Box+BoxChild
			this.txtIDUsuario = new global::Gtk.Entry();
			this.txtIDUsuario.CanFocus = true;
			this.txtIDUsuario.Name = "txtIDUsuario";
			this.txtIDUsuario.IsEditable = true;
			this.txtIDUsuario.InvisibleChar = '•';
			this.vbox36.Add(this.txtIDUsuario);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox36[this.txtIDUsuario]));
			w24.Position = 2;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox36.Gtk.Box+BoxChild
			this.combobox4 = global::Gtk.ComboBox.NewText();
			this.combobox4.Name = "combobox4";
			this.vbox36.Add(this.combobox4);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox36[this.combobox4]));
			w25.Position = 3;
			w25.Expand = false;
			w25.Fill = false;
			this.hbox33.Add(this.vbox36);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox33[this.vbox36]));
			w26.Position = 2;
			w26.Expand = false;
			w26.Fill = false;
			this.vbox35.Add(this.hbox33);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox35[this.hbox33]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.vbox34.Add(this.vbox35);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox34[this.vbox35]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox34.Gtk.Box+BoxChild
			this.hbox37 = new global::Gtk.HBox();
			this.hbox37.Name = "hbox37";
			this.hbox37.Spacing = 6;
			// Container child hbox37.Gtk.Box+BoxChild
			this.alignment34 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment34.Name = "alignment34";
			this.hbox37.Add(this.alignment34);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.alignment34]));
			w29.Position = 0;
			// Container child hbox37.Gtk.Box+BoxChild
			this.alignment33 = new global::Gtk.Alignment(0.5F, 0.5F, 1F, 1F);
			this.alignment33.Name = "alignment33";
			this.hbox37.Add(this.alignment33);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.alignment33]));
			w30.Position = 1;
			// Container child hbox37.Gtk.Box+BoxChild
			this.hbox38 = new global::Gtk.HBox();
			this.hbox38.Name = "hbox38";
			this.hbox38.Spacing = 6;
			this.hbox38.BorderWidth = ((uint)(6));
			// Container child hbox38.Gtk.Box+BoxChild
			this.btnNuevo = new global::Gtk.Button();
			this.btnNuevo.CanFocus = true;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.UseUnderline = true;
			this.btnNuevo.Label = global::Mono.Unix.Catalog.GetString("Nuevo");
			this.hbox38.Add(this.btnNuevo);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox38[this.btnNuevo]));
			w31.Position = 0;
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbox38.Gtk.Box+BoxChild
			this.btnAgregar = new global::Gtk.Button();
			this.btnAgregar.CanFocus = true;
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.UseUnderline = true;
			this.btnAgregar.Label = global::Mono.Unix.Catalog.GetString("Agregar");
			this.hbox38.Add(this.btnAgregar);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox38[this.btnAgregar]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbox38.Gtk.Box+BoxChild
			this.btnEditar = new global::Gtk.Button();
			this.btnEditar.CanFocus = true;
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.UseUnderline = true;
			this.btnEditar.Label = global::Mono.Unix.Catalog.GetString("Editar");
			this.hbox38.Add(this.btnEditar);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.hbox38[this.btnEditar]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			this.hbox37.Add(this.hbox38);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.hbox37[this.hbox38]));
			w34.Position = 2;
			w34.Expand = false;
			w34.Fill = false;
			this.vbox34.Add(this.hbox37);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox34[this.hbox37]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			this.Add(this.vbox34);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 846;
			this.DefaultHeight = 332;
			this.Show();
			this.btnSalir.Clicked += new global::System.EventHandler(this.OnBtnSalirClicked);
		}
	}
}