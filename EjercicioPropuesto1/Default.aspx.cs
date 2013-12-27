using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPropuesto1
{
    public partial class _Default : System.Web.UI.Page
    {
        private RadioButton[] respuestasCuestionario;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            RadioButton[] respuestaCorrectas = {rdRespuesta11, rdRespuesta21, rdRespuesta34,rdRespuesta43,rdRespuesta51,rdRespuesta62};
            respuestasCuestionario = respuestaCorrectas;
        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            int numeroCorrectas = VerificarRespuesta(respuestasCuestionario);
            lblTest.Text = "Numero de preguntas correctas " + numeroCorrectas;                                               
        }

        private int VerificarRespuesta(RadioButton[] respuestasCuestionario)
        {
            int nroRespuestasCorrectas = 0;
            foreach (RadioButton radio in respuestasCuestionario)
            {
                if (radio.Checked)
                {
                   nroRespuestasCorrectas++;
                }
            }
            return nroRespuestasCorrectas;
        }

    }
}