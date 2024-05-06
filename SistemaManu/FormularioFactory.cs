using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SistemaManu
{
    public class FormularioFactory
    {
        private readonly string nombreMenu;

        public FormularioFactory(string nombreMenu)
        {
            this.nombreMenu = nombreMenu;
        }

        public Form CreateForm<T>() where T : Form, IMenuRecipient, new()
        {
            T form = new T();
            IMenuRecipient menuRecipient = form as IMenuRecipient;

            if (menuRecipient != null)
            {
                menuRecipient.NombreMenu = nombreMenu;
            }
            else
            {
                throw new InvalidOperationException($"El formulario {typeof(T).Name} no implementa la interfaz IMenuRecipient.");
            }

            return form;
        }
    }
}
