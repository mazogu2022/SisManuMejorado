using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//using Microsoft.Office.Interop.Word;

namespace SistemaManu
{
    public partial class FrmPlantilla1 : Form, IMenuRecipient
    {

        public string NombreMenu { get; set; }
        public FrmPlantilla1()
        {
            InitializeComponent();
            // Permitir redimensionamiento del formulario
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
       
        private void FrmPlantilla1_Load(object sender, EventArgs e)
        {
            labeltitulo.Text = NombreMenu;
        }
        #region PARA REDIMENCIONAR EL FORMULARIO

        private const int tolerance = 16; // Tolerancia del control de tamaño
        private Rectangle sizeGripRectangle; // Rectángulo para el control de tamaño

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // Calcular la posición del control de tamaño
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance,
                                              this.ClientRectangle.Height - tolerance,
                                              tolerance, tolerance);

            // Invalidar el formulario para que se redibuje
            this.Invalidate(sizeGripRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar el control de tamaño
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, sizeGripRectangle);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            const int WM_NCHITTEST = 0x0084;
            const int HTBOTTOMRIGHT = 17;

            // Permitir que el usuario redimensione el formulario al hacer clic y arrastrar en el control de tamaño
            if (m.Msg == WM_NCHITTEST)
            {
                int x = (int)(m.LParam.ToInt64() & 0xFFFF);
                int y = (int)((m.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point point = this.PointToClient(new Point(x, y));

                if (sizeGripRectangle.Contains(point))
                {
                    m.Result = (IntPtr)HTBOTTOMRIGHT;
                    return;
                }
            }
        }
        #endregion
        #region PARA MOVER FORMULARIO

        //CODIGO PARA MOVER EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //PARA CERRAR EL FORMULARIO HIJO

        //PARA MINIMIZAR EL FORMULARIO HIJO
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //METODO PARA MOVER EL FORMULARIO DESDE LA BARRA DE TITULO
        private void paneltitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
    }
}
