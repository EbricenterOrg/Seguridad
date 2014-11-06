using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAplicaciones;
using HSC_gestionPerfiles;
using HSC_gestionUsuarios;


namespace Administrador
{
    internal class csAplicacionesDisponibles
    {
        private wfAdminitrador Admin = new wfAdminitrador();
        public void vCrearInterfaz()
        {
            Admin.NuevaCategoria("Formularios de Ingreso");
            Admin.NuevaBotonDesplegable("Perfiles",new wftabm_SGperfil(),1,global::Administrador.Properties.Resources.Profile);
            Admin.NuevoItemMenu("Asignar App's a Perfil", new wftabt_SGperfilapp(), 1);
            Admin.NuevoItemMenu("Asignar Usuarios a Perfil", new wftabt_SGperfiluser(), 1);
            Admin.NuevaBotonDesplegable("Usuarios",new wftabm_SGusuario(),2,global::Administrador.Properties.Resources.User);
            Admin.NuevoItemMenu("Privilegios",new wftabm_SGprivilegio(),2);
            Admin.NuevoItemMenu("Pregunta",new wftabm_SGpregunta(),2);
            Admin.NuevaBotonDesplegable("Aplicaciones",new wfrPrincipal(),2,global::Administrador.Properties.Resources.App2);
            Admin.NuevoItemMenu("Aplicaciones a Usuarios",new wfrAgregarQuitar_tab_apli(),2);
        }
    }
}
