using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaManu.Logica;

namespace SistemaManu
{
    public partial class FrmUbigeo : FrmPlantilla1, IMenuRecipient
    {
        public string distritoSeleccionado;
        public string provinciaSeleccionada;
        public string departamentoSeleccionado;
        private BindingSource bs = new BindingSource();
        public FrmUbigeo()
        {
            InitializeComponent();
            txtbuscar.TextChanged += txtbuscar_TextChanged;
        }

        private void FrmUbigeo_Load(object sender, EventArgs e)
        {
         
            this.ListadoUbigeo();
            txtbuscar.Focus();
            
        }
        private void ListadoUbigeo()
        {

            LUbigeo Datos = new LUbigeo();
            bs.DataSource = Datos.ListadoUbigeo();
            dgvUbigeo.DataSource = bs;
        }

        private void dgvUbigeo_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgvUbigeo.SelectedRows[0];

            distritoSeleccionado = fila.Cells["distrito"].Value.ToString();
            provinciaSeleccionada = fila.Cells["provincia"].Value.ToString();
            departamentoSeleccionado = fila.Cells["departamento"].Value.ToString();

            this.Close();
        }
        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = $"distrito LIKE '%{txtbuscar.Text}%'";
        }
    }
}
