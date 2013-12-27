using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            string valor = txtValor1.Text;
            double numero;
            if (double.TryParse(valor, out numero))
               lblTest.Text = "El numero tiene "+ Math.Ceiling(Math.Log10(numero))+" digitos";
            else
                lblTest.Text = "No es numerico";
        }
    }
}