using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI_V_2
{
    class Utilidades
    {






        public static Boolean ValidarFormulario(Control objeto, ErrorProvider ErrorProvider)
        {
            Boolean HayError = false;

            foreach (Control Item in objeto.Controls)
            {
                if(Item is ErrorTxtBox){
                    ErrorTxtBox obj = (ErrorTxtBox)Item;
                    if (obj.Validar==true)
                    {
                        if (String.IsNullOrEmpty(obj.Text.Trim()))
                        {
                            ErrorProvider.SetError(obj, "No puede estar en blanco");
                            HayError = true;

                        }
                    }
                    else
                    {
                        ErrorProvider.SetError(obj,"");
                    }

                }

            }

            return HayError;
        }



    }
}
