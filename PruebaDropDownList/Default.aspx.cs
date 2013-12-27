using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Operaciones;

namespace PruebaDropDownList
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
            if (ddlOperacion.SelectedValue == "Sumar")
            {
                respuesta += "El valor de la suma es " + Operacion.Sumar(valor1, valor2) + Environment.NewLine;
            }
            else if (ddlOperacion.SelectedValue == "Restar")
            {
                respuesta += "El valor de la resta es " + Operacion.Restar(valor1, valor2) + Environment.NewLine;
            }
            else if (ddlOperacion.SelectedValue == "Multiplicar")
            {
                respuesta += "El valor de la multiplicacion es " + Operacion.Multiplicar(valor1, valor2) + Environment.NewLine;
            }
            else
            {
                respuesta += "El valor de la division es " + Operacion.Dividir(valor1, valor2) + Environment.NewLine;
            }
            lblTest.Text = respuesta;
        }
    }
}