using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador
{
    public partial class wfAdminitrador : Form
    {
        private static ToolStrip MenuAdmin = new ToolStrip();
        private ToolStripLabel tslCategoria;
        private ToolStripButton tsbBoton;
        private ToolStripDropDownButton tsdListaDesplegable;
        private ToolStripMenuItem tsmItemMenu;
        private ToolStripLabel tslTitulo;
        private Form fFormAnterior;
        private Form fFormularioPrincipal;
         private static int iPrivi = 0;

        public wfAdminitrador()
        {
            InitializeComponent();
        }

        public int Privilegio
        {
            set { iPrivi = value; }
        }

        private void CargarFormulario(object sender, EventArgs e)
        {
            Form Cargar = new Form();
            if (sender is ToolStripButton)
            {
                var vBoton = (ToolStripButton)sender;
                if (vBoton.Tag != null) { Cargar = (Form)vBoton.Tag; }
            }
            else
            {
                if (sender is ToolStripMenuItem)
                {
                    var vMenuItem = (ToolStripMenuItem)sender;
                    if (vMenuItem.Tag != null) { Cargar = (Form)vMenuItem.Tag; }
                }
                else
                {
                    if (sender is ToolStripDropDownButton)
                    {
                        var vBotonDesp = (ToolStripDropDownButton)sender;
                        if (vBotonDesp.Tag != null) { Cargar = (Form)vBotonDesp.Tag; }
                    }
                }
            }
            try
            {
                if (fFormAnterior != null) { fFormAnterior.Hide(); }
                    Assembly asm = Assembly.GetEntryAssembly();
                    fFormularioPrincipal = new Form();
                    fFormularioPrincipal = Cargar;
                    fFormularioPrincipal.Activate();
                    fFormularioPrincipal.FormBorderStyle = FormBorderStyle.None;
                    fFormularioPrincipal.Dock = DockStyle.Fill;
                    fFormularioPrincipal.Size = new System.Drawing.Size(this.Width,this.Height);
                    fFormularioPrincipal.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    fFormularioPrincipal.MdiParent = wfAdminitrador.ActiveForm;
                    fFormularioPrincipal.Show();
                    fFormAnterior = fFormularioPrincipal;          
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        public void vCargarAdministrador()
        {

            try
            {
                wfAdminitrador Admin = new wfAdminitrador();
                MenuAdmin = new ToolStrip();
                new csAplicacionesDisponibles().vCrearInterfaz();
                MenuAdmin.AutoSize = false;
                MenuAdmin.Width = 320;
                MenuAdmin.BackColor = Color.Black;
                MenuAdmin.GripStyle = ToolStripGripStyle.Hidden;
                MenuAdmin.Dock = DockStyle.Left;
                Admin.Controls.Add(MenuAdmin);
                Admin.Show();
            }
            catch { }
        }

        public void NuevaCategoria(String Categoria)
        {
            Titulo();
            tslCategoria = new ToolStripLabel();
            tslCategoria.Name = Categoria;
            tslCategoria.Text = Categoria;
            tslCategoria.AutoSize = false;
            tslCategoria.Height = 50;
            tslCategoria.Width = 250;
            tslCategoria.Font = new Font("Century Gothic", 12, FontStyle.Underline);
            tslCategoria.ForeColor = Color.LightGray;
            tslCategoria.TextAlign = ContentAlignment.MiddleLeft;
            tslCategoria.DisplayStyle = ToolStripItemDisplayStyle.Text;
            MenuAdmin.Items.Add(tslCategoria);
        }

        public void NuevoBoton(String Nombre, Form CargarForm, int Nivel, Bitmap Imagen = null)
        {
            Titulo();
            tsbBoton = new ToolStripButton();
            tsbBoton.Name = Nivel.ToString();
            tsbBoton.Text = "  " + Nombre;
            tsbBoton.Tag = CargarForm;
            tsbBoton.Font = new Font("Century Gothic", 12);
            tsbBoton.TextAlign = ContentAlignment.MiddleLeft;
            tsbBoton.ForeColor = Color.LightGray;
            tsbBoton.Click += new EventHandler(CargarFormulario);
            tsbBoton.Image = Imagen;
            tsbBoton.ImageScaling = ToolStripItemImageScaling.None;
            tsbBoton.ImageAlign = ContentAlignment.MiddleLeft;
            if (iPrivi <= Nivel)
            {
                MenuAdmin.Items.Add(tsbBoton);
            }
        }

        public void NuevoBoton(String Nombre, Form CargarForm, int Nivel)
        {
            Titulo();
            tsbBoton = new ToolStripButton();
            tsbBoton.Name = Nivel.ToString();
            tsbBoton.Text = "  " + Nombre;
            tsbBoton.Tag = CargarForm;
            tsbBoton.Font = new Font("Century Gothic", 12);
            tsbBoton.TextAlign = ContentAlignment.MiddleLeft;
            tsbBoton.ForeColor = Color.LightGray;
            tsbBoton.Click += new EventHandler(CargarFormulario);
            tsbBoton.ImageScaling = ToolStripItemImageScaling.None;
            tsbBoton.ImageAlign = ContentAlignment.MiddleLeft;
            if (iPrivi <= Nivel)
            {
                MenuAdmin.Items.Add(tsbBoton);
            }
        }

        public void NuevaBotonDesplegable(String Nombre, int Nivel, Bitmap Imagen = null)
        {
            Titulo();
            tsdListaDesplegable = new ToolStripDropDownButton();
            tsdListaDesplegable.Name = Nivel.ToString();
            tsdListaDesplegable.Text = "  " + Nombre;
            tsdListaDesplegable.Font = new Font("Century Gothic", 12);
            tsdListaDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.Click += new EventHandler(CargarFormulario);
            tsdListaDesplegable.Image = Imagen;
            tsdListaDesplegable.ImageScaling = ToolStripItemImageScaling.None;
            tsdListaDesplegable.ImageAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.ForeColor = Color.LightGray;
            if (iPrivi <= Nivel)
            {
                MenuAdmin.Items.Add(tsdListaDesplegable);
            }
        }

        public void NuevaBotonDesplegable(String Nombre, Form CargarForm, int Nivel, Bitmap Imagen = null)
        {
            Titulo();
            tsdListaDesplegable = new ToolStripDropDownButton();
            tsdListaDesplegable.Name = Nivel.ToString();
            tsdListaDesplegable.Text = "  " + Nombre;
            tsdListaDesplegable.Tag = CargarForm;
            tsdListaDesplegable.Font = new Font("Century Gothic", 12);
            tsdListaDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.Click += new EventHandler(CargarFormulario);
            tsdListaDesplegable.Image = Imagen;
            tsdListaDesplegable.ImageScaling = ToolStripItemImageScaling.None;
            tsdListaDesplegable.ImageAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.ForeColor = Color.LightGray;
            if (iPrivi <= Nivel)
            {
                MenuAdmin.Items.Add(tsdListaDesplegable);
            }
        }

        public void NuevaBotonDesplegable(String Nombre, Form CargarForm, int Nivel)
        {
            Titulo();
            tsdListaDesplegable = new ToolStripDropDownButton();
            tsdListaDesplegable.Name = Nivel.ToString();
            tsdListaDesplegable.Text = "  " + Nombre;
            tsdListaDesplegable.Tag = CargarForm;
            tsdListaDesplegable.Font = new Font("Century Gothic", 12);
            tsdListaDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.Click += new EventHandler(CargarFormulario);
            tsdListaDesplegable.ImageScaling = ToolStripItemImageScaling.None;
            tsdListaDesplegable.ImageAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.ForeColor = Color.LightGray;
            if (iPrivi <= Nivel)
            {
                MenuAdmin.Items.Add(tsdListaDesplegable);
            }
        }

        public void NuevoItemMenu(String Nombre, Form CargarForm, int Nivel, Bitmap Imagen = null)
        {
            Titulo();
            tsmItemMenu = new ToolStripMenuItem();
            tsmItemMenu.Name = Nivel.ToString();
            tsmItemMenu.Text = "  " + Nombre;
            tsmItemMenu.Tag = CargarForm;
            tsmItemMenu.Font = new Font("Century Gothic", 12);
            tsmItemMenu.TextAlign = ContentAlignment.MiddleLeft;
            tsmItemMenu.Click += new EventHandler(CargarFormulario);
            tsmItemMenu.Image = Imagen;
            tsmItemMenu.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tsmItemMenu.ImageAlign = ContentAlignment.MiddleLeft;
            tsmItemMenu.ForeColor = Color.DarkGray;
            if (iPrivi <= Nivel)
            {
                tsdListaDesplegable.DropDownItems.Add(tsmItemMenu);
            }
        }

        public void NuevoItemMenu(String Nombre, Form CargarForm, int Nivel)
        {
            Titulo();
            tsmItemMenu = new ToolStripMenuItem();
            tsmItemMenu.Name = Nivel.ToString();
            tsmItemMenu.Text = "  " + Nombre;
            tsmItemMenu.Tag = CargarForm;
            tsmItemMenu.Font = new Font("Century Gothic", 12);
            tsmItemMenu.TextAlign = ContentAlignment.MiddleLeft;
            tsmItemMenu.Click += new EventHandler(CargarFormulario);
            tsmItemMenu.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tsmItemMenu.ImageAlign = ContentAlignment.MiddleLeft;
            tsmItemMenu.ForeColor = Color.DarkGray;
            if (iPrivi <= Nivel)
            {
                tsdListaDesplegable.DropDownItems.Add(tsmItemMenu);
            }
        }

        private void Titulo()
        {
            if (tslTitulo == null)
            {
                tslTitulo = new ToolStripLabel();
                tslTitulo.Text = "Administración";
                tslTitulo.Font = new Font("Century Gothic", 18);
                tslTitulo.ImageAlign = ContentAlignment.MiddleLeft;
                tslTitulo.ForeColor = Color.LightGray;
                tslTitulo.Image = global::Administrador.Properties.Resources.Admin;
                tslTitulo.ImageScaling = ToolStripItemImageScaling.None;
                MenuAdmin.Items.Add(tslTitulo);
            }
        }

        private void wfAdminitrador_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuAdmin = new ToolStrip();
        }

    }
}
