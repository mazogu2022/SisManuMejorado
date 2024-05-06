using SistemaManu.Logica;
using SistemaManu.Modelo;
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
    public partial class L_Titular : FrmPlantilla
    {
        private LTitular logicaTitular = new LTitular();
 
        private BindingSource bs = new BindingSource();
        public L_Titular()
        {
            InitializeComponent();
        }

        private void L_Titular_Load(object sender, EventArgs e)
        {
            this.Listadotitular();      
        }
        private void Listadotitular()
        {

            LTitular Datos = new LTitular();
            bs.DataSource = Datos.Listadotitular();
            dgvtitular.DataSource = bs;
        }

        private void txtbuscartirular_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = $"empresa LIKE '%{txtbuscartirular.Text}%'";
            Listadotitular(); // Llamar al método Listadotitular para aplicar el filtro
        }

        private void txtbuscarruc_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = $"ruc LIKE '%{txtbuscarruc.Text}%'";
            Listadotitular(); // Llamar al método Listadotitular para aplicar el filtro
        }        

    }
}
