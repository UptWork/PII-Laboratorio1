using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Operaciones;

namespace PruebaRadioButton
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
            string respuesta = "El valor de la";
            if(rdSuma.Checked)
            {
                respuesta += " suma es " + Operacion.Sumar(valor1, valor2);
            }
            else
            {
                respuesta += " resta es " + Operacion.Restar(valor1, valor2);
            }
            lblTest.Text = respuesta;
        }

       
    }
}