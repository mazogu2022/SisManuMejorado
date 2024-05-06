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
    public partial class FrmTitularNuevo : FrmPlantilla1, IMenuRecipient
    {
        public FrmTitularNuevo()
        {
            InitializeComponent();
            this.Shown += FrmTitularNuevo_Shown;

        }
        #region PARA UBIGEO
        private void btnUbigeo_Click(object sender, EventArgs e)
        {
            frmUbigeo = new FrmUbigeo();
            frmUbigeo.FormClosed += FrmUbigeo_FormClosed;
            frmUbigeo.ShowDialog();
        }
        public void setUbigeo(String ubigeo)
        {
            txtdistrito.Text = ubigeo;
            txtprovincia.Text = ubigeo;
            txtdepartamento.Text = ubigeo;
        }
        private FrmUbigeo frmUbigeo;
        private void FrmUbigeo_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtdistrito.Text = frmUbigeo.distritoSeleccionado;
            txtprovincia.Text = frmUbigeo.provinciaSeleccionada;
            txtdepartamento.Text = frmUbigeo.departamentoSeleccionado;
        }
        #endregion

        #region RADIOBUTON
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            txtllama11.Text = "la empresa";
            txtllama22.Text = "La empresa";
            txtllama33.Text = "a la empresa";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txtllama11.Text = "la señora";
            txtllama22.Text = "La señora";
            txtllama33.Text = "a la señora";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            txtllama11.Text = "el señor";
            txtllama22.Text = "El señor";
            txtllama33.Text = "al señor";
        }
        #endregion

        private void FrmTitularNuevo_Shown(object sender, EventArgs e)
        {
            // Colocar el foco en la caja de texto dentro del GroupBox
            txtempresa.Focus();
        }
        private void FrmTitularNuevo_Load(object sender, EventArgs e)
        {
            txtempresa.Focus();
        }
    }
}
