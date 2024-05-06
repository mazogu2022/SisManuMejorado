using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//para reemplazar datos a word
using Word = Microsoft.Office.Interop.Word;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using SistemaManu.Logica;
//using SistemaManu.Modelo;

namespace SistemaManu
{
    public partial class FrmNuevo : FrmPlantilla, IMenuRecipient
    {
        private string sourceFile = @"D:\proyectos c#\SisManu-20240422T104820Z-001\SisManu\SistemaManu\temp.docx"; // Ruta del archivo fuente
        //public string NombreMenu { get; set; }
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void FrmNuevo_Load(object sender, EventArgs e)
        {
           
        }
        #region PARA GENERAR DOCUMENTO WORD
        //Método buscar y reemplazar:
        private void FindAndReplace(Microsoft.Office.Interop.Word.Application wordApp, object findText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref findText,
                        ref matchCase, ref matchWholeWord,
                        ref matchWildCards, ref matchSoundLike,
                        ref nmatchAllForms, ref forward,
                        ref wrap, ref format, ref replaceWithText,
                        ref replace, ref matchKashida,
                        ref matchDiactitics, ref matchAlefHamza,
                        ref matchControl);
        }


        //Método Crear el documento:
        private void CreateWordDocument(object filename, object savaAs)
        {
            Word.Application wordApp = new Word.Application();
            object missing = Missing.Value;
            Word.Document midocumento = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                wordApp.Visible = false;

                midocumento = wordApp.Documents.Open(ref filename, ref missing, ref readOnly,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing,
                                            ref missing, ref missing, ref missing, ref missing);

                midocumento.Activate();

                //Find and replace:
                this.FindAndReplace(wordApp, "<nombre>", txtnombre.Text);
                this.FindAndReplace(wordApp, "<direccion>", txtdireccion.Text);
                this.FindAndReplace(wordApp, "<telefono>", txttelefono.Text);
                this.FindAndReplace(wordApp, "<correo>", txtcorreo.Text);
                this.FindAndReplace(wordApp, "<distrito>", txtdistrito.Text);
                this.FindAndReplace(wordApp, "<provincia>", txtprovincia.Text);
                this.FindAndReplace(wordApp, "<departamento>", txtdepartamento.Text);
                this.FindAndReplace(wordApp, "<fecha>", DateTime.Now.ToShortDateString());

            }
            else
            {
                MessageBox.Show("el archivo no existe.");
                return;
            }

            //Save as: filename
            midocumento.SaveAs2(ref savaAs, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing);
            midocumento.Close();
            wordApp.Quit();
            // Abrir el documento en Microsoft Word
            
            MessageBox.Show("Documento creado");

            // Abrir el documento con Microsoft Word
            Process.Start((string)savaAs);

        }

        private void btngenerar_Click_1(object sender, EventArgs e)
        {
            string documentosFolder = @"D:\proyectos c#\SisManu-20240422T104820Z-001\SisManu\SistemaManu\Documentos"; // Ruta de la carpeta "Documentos"

            // Combinar datos de las cajas de texto para crear el nombre del archivo
            string nombreArchivo = $"{txtnombre.Text} {txtcorreo.Text}.docx";

            // Combinar ruta de la carpeta "Documentos" y nombre del archivo
            string destinoCompleto = Path.Combine(documentosFolder, nombreArchivo);

            try
            {
                // Crear el documento utilizando el nombre de archivo de destino y la nueva ruta
                this.CreateWordDocument(sourceFile, destinoCompleto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        #endregion
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
    }
}