using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp12
{
    internal class closefrms
    {
        public static void closefrm() //metodo
        {
            var closeform = Application.OpenForms.Cast<Form>().ToList();
            foreach (Form frm in closeform)
            {
                frm.Close();    //this closes the program
            }
        }
    }
}
