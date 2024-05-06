using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Word;


namespace SistemaManu
{
    public partial class FrmPlantilla : Form, IMenuRecipient
    {
        public string NombreMenu { get; set; }
        public FrmPlantilla()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FrmPlantilla_Load(object sender, EventArgs e)
        {
            labeltitulo.Text = NombreMenu;
        }
        #region PARA REDIMENCIONAR UN FORMULARIO
        ////RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        //private int tolerance = 12;
        //private const int WM_NCHITTEST = 132;
        //private const int HTBOTTOMRIGHT = 17;
        //private Rectangle sizeGripRectangle;
        //protected override void WndProc(ref Message m)
        //{
        //    switch (m.Msg)
        //    {
        //        case WM_NCHITTEST:
        //            base.WndProc(ref m);
        //            var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
        //            if (sizeGripRectangle.Contains(hitPoint))
        //                m.Result = new IntPtr(HTBOTTOMRIGHT);
        //            break;
        //        default:
        //            base.WndProc(ref m);
        //            break;
        //    }
        //}
        ////----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);
        //    var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
        //    sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
        //    region.Exclude(sizeGripRectangle);
        //    this.panelcontenedor.Region = region;
        //    this.Invalidate();
        //}
        ////----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
        //    e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        //}
        #endregion
        #region PARA MOVER FORMULARIO

        //PARA CERRAR EL FORMULARIO HIJO
        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //PARA MINIMIZAR EL FORMULARIO HIJO
        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODO PARA MOVER EL FORMULARIO DESDE LA BARRA DE TITULO
        private void paneltitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //CODIGO PARA MOVER EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
    #endregion
}
