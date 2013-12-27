using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaTextBox
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int respuestaSuma  = Sumar(Convert.ToInt32(txtValor1.Text), Convert.ToInt32(txtValor2.Text));
            lblTest.Text = "La suma de los dos valores es : " + respuestaSuma;
        }

        private int Sumar(int valor1,int valor2)
        {
            return valor1 + valor2;
        }
    }
}