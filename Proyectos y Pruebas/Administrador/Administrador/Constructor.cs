using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Administrador
{
    public class Constructor
    {
        private ToolStrip MenuAdmin = new ToolStrip();
        private ToolStripLabel tslCategoria;
        private ToolStripButton tsbBoton;
        private ToolStripDropDownButton tsdListaDesplegable;
        private ToolStripMenuItem tsmItemMenu;
        ToolStripLabel tslTitulo;
        private Form fFormAnterior;
        private bool bTitulo = false;

        public void Titulo() 
        {
            if (tslTitulo == null)
            {
                tslTitulo = new ToolStripLabel();
                tslTitulo.Text = "Administración";
                tslTitulo.Font = new Font("Century Gothic", 18);
                tslTitulo.ForeColor = Color.LightGray;
                tslTitulo.Image = global::Administrador.Properties.Resources.Admin;
                tslTitulo.ImageScaling = ToolStripItemImageScaling.None;
                MenuAdmin.Items.Add(tslTitulo);
            }
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
            tslCategoria.Font = new Font("Century Gothic",12, FontStyle.Underline);
            tslCategoria.ForeColor = Color.LightGray;
            tslCategoria.TextAlign = ContentAlignment.MiddleLeft;
            tslCategoria.DisplayStyle = ToolStripItemDisplayStyle.Text;
            this.MenuAdmin.Items.Add(tslCategoria);
        }

        public void NuevoBoton(String Nombre, Bitmap Imagen, String CargarForm)
        {
            Titulo();
            tsbBoton = new ToolStripButton();
            tsbBoton.Name = Nombre;
            tsbBoton.Text = "  " + Nombre;
            tsbBoton.Tag = CargarForm;
            tsbBoton.Font = new Font("Century Gothic", 12);
            tsbBoton.TextAlign = ContentAlignment.MiddleLeft;
            tsbBoton.ForeColor = Color.LightGray;
            tsbBoton.Click += new EventHandler(CargarFormulario);
            tsbBoton.Image = Imagen;
            tsbBoton.ImageScaling = ToolStripItemImageScaling.None;
            tsbBoton.ImageAlign = ContentAlignment.MiddleLeft;
            this.MenuAdmin.Items.Add(tsbBoton);
        }

        public void NuevaBotonDesplegable(String Nombre, Bitmap Imagen)
        {
            Titulo();
            tsdListaDesplegable = new ToolStripDropDownButton();
            tsdListaDesplegable.Name = Nombre;
            tsdListaDesplegable.Text = "  " + Nombre;
            tsdListaDesplegable.Font = new Font("Century Gothic", 12);
            tsdListaDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.Click += new EventHandler(CargarFormulario);
            tsdListaDesplegable.Image = Imagen;
            tsdListaDesplegable.ImageScaling = ToolStripItemImageScaling.None;
            tsdListaDesplegable.ImageAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.ForeColor = Color.LightGray;
            this.MenuAdmin.Items.Add(tsdListaDesplegable);
        }

        public void NuevaBotonDesplegable(String Nombre, Bitmap Imagen, String CargarForm)
        {
            Titulo();
            tsdListaDesplegable = new ToolStripDropDownButton();
            tsdListaDesplegable.Name = Nombre;
            tsdListaDesplegable.Text = "  " + Nombre;
            tsdListaDesplegable.Tag = CargarForm;
            tsdListaDesplegable.Font = new Font("Century Gothic", 12);
            tsdListaDesplegable.TextAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.Click += new EventHandler(CargarFormulario);
            tsdListaDesplegable.Image = Imagen;
            tsdListaDesplegable.ImageScaling = ToolStripItemImageScaling.None;
            tsdListaDesplegable.ImageAlign = ContentAlignment.MiddleLeft;
            tsdListaDesplegable.ForeColor = Color.LightGray;
            this.MenuAdmin.Items.Add(tsdListaDesplegable);
        }

        public void NuevoItemMenu(String Nombre, Bitmap Imagen,String CargarForm) 
        {
            Titulo();
            tsmItemMenu = new ToolStripMenuItem();
            tsmItemMenu.Name = Nombre;
            tsmItemMenu.Text = "  " + Nombre;
            tsmItemMenu.Tag = CargarForm;
            tsmItemMenu.Font = new Font("Century Gothic", 12);
            tsmItemMenu.TextAlign = ContentAlignment.MiddleLeft;
            tsmItemMenu.Click += new EventHandler(CargarFormulario);
            tsmItemMenu.Image = Imagen;
            tsmItemMenu.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            tsmItemMenu.ImageAlign = ContentAlignment.MiddleLeft;
            tsmItemMenu.ForeColor = Color.DarkGray;
            tsdListaDesplegable.DropDownItems.Add(tsmItemMenu);
        }

        private void CargarFormulario(object sender, EventArgs e) 
        {
            String Cargar = String.Empty;
            if (sender is ToolStripButton) 
            {
                var vBoton = (ToolStripButton)sender;
                if (vBoton.Tag != null) { Cargar = vBoton.Tag.ToString() + ""; }  
            }
            else 
            {
                if (sender is ToolStripMenuItem) 
                {
                    var vMenuItem = (ToolStripMenuItem)sender;
                    if (vMenuItem.Tag != null) { Cargar = vMenuItem.Tag.ToString() + ""; }    
                }
                else 
                {
                    if (sender is ToolStripDropDownButton) 
                    {
                        var vBotonDesp = (ToolStripDropDownButton)sender;
                        if (vBotonDesp.Tag != null) { Cargar = vBotonDesp.Tag.ToString() + ""; }  
                    }
                }
            }
            try
            {
                if (fFormAnterior != null) { fFormAnterior.Hide(); }
                Assembly asm = Assembly.GetEntryAssembly();
                Type formtype = asm.GetType(Cargar);
                Form fFormularioPrincipal = (Form)Activator.CreateInstance(formtype);
                fFormularioPrincipal.FormBorderStyle = FormBorderStyle.None;
                fFormularioPrincipal.Dock = DockStyle.Fill;
                fFormularioPrincipal.TopLevel = false;
                fFormularioPrincipal.WindowState = FormWindowState.Maximized;
                fFormularioPrincipal.MdiParent = Administracion.ActiveForm;
                fFormularioPrincipal.Show();
                fFormAnterior = fFormularioPrincipal;
            }catch(Exception){}
        }
        
        public ToolStrip CargarControles
        {
            get 
            {
                MenuAdmin.AutoSize = false;
                MenuAdmin.Width = 250;
                MenuAdmin.BackColor = Color.Black;
                MenuAdmin.GripStyle = ToolStripGripStyle.Hidden;
                MenuAdmin.Dock = DockStyle.Left;
                return MenuAdmin; 
            }
        }

    }
}
