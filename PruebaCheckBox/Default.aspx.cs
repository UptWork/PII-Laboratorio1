using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Operaciones;

namespace PruebaCheckBox
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txtValor1.Text);
            int valor2 = Convert.ToInt32(txtValor2.Text);
            string respuesta = String.Empty;
            if (chkSumar.Checked)
            {
                respuesta += "El valor de la suma es " + Operacion.Sumar(valor1, valor2) + Environment.NewLine;
            }
            if(chkRestar.Checked)
            {
                respuesta += "El valor de la resta es " + Operacion.Restar(valor1, valor2) + Environment.NewLine;
            }
            lblTest.Text = respuesta;
        }
    }
}