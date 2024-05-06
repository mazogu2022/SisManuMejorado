using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaManu
{
    public partial class FormularioPrincipal : Form
    {
        
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private Dictionary<Type, Form> formulariosAbiertos = new Dictionary<Type, Form>();
        private void AbrirFormulario<T>(string nombrePestania) where T : Form, IMenuRecipient, new()
        {
            // Verificar si ya hay una instancia del formulario abierto
            Type tipoFormulario = typeof(T);
            if (formulariosAbiertos.ContainsKey(tipoFormulario))
            {
                formulariosAbiertos[tipoFormulario].BringToFront();
                return;
            }

            // Si no hay una instancia del formulario abierto, crear una nueva
            var factory = new FormularioFactory(nombrePestania);
            var formularioHijo = factory.CreateForm<T>();
            formularioHijo.MdiParent = this;
            formularioHijo.FormClosed += (sender, args) => formulariosAbiertos.Remove(tipoFormulario); // Eliminar formulario del diccionario cuando se cierra
            formulariosAbiertos.Add(tipoFormulario, formularioHijo);
            formularioHijo.Show();
            formularioHijo.BringToFront();
        }

        private void aplicativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string nombrePestania = ((ToolStripMenuItem)sender).Text;
            //AbrirFormulario<FrmPlantilla>(nombrePestania);
        }

        private void fORMULARIONUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombrePestania = ((ToolStripMenuItem)sender).Text;
            AbrirFormulario<FrmNuevo>(nombrePestania);
        }

        private void pRIVADOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombrePestania = ((ToolStripMenuItem)sender).Text;
            AbrirFormulario<FrmPrivados>(nombrePestania);
        }

        private void uBIGEOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombrePestania = ((ToolStripMenuItem)sender).Text;
            AbrirFormulario<FrmUbigeo>(nombrePestania);
        }

        private void hojaDeRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombrePestania = ((ToolStripMenuItem)sender).Text;
            AbrirFormulario<L_HojaRuta>(nombrePestania);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string nombrePestania = ((ToolStripMenuItem)sender).Text;
            //AbrirFormulario<FrmHojaRutaNuevo>(nombrePestania);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string nombrePestania = ((ToolStripMenuItem)sender).Text;
            //AbrirFormulario<FrmHojaRutaModificar>(nombrePestania);
        }

        private void titularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevaEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombrePestania = ((ToolStripMenuItem)sender).Text;
            AbrirFormulario<FrmTitularNuevo>(nombrePestania);
        }

        private void listadoDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nombrePestania = ((ToolStripMenuItem)sender).Text;
            AbrirFormulario<L_Titular>(nombrePestania);
        }
    }
}
