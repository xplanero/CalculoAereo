using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Aereonautica_
{
    public partial class UnidadPresion : Form
    {
        public UnidadPresion()
        {
            InitializeComponent();


        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer el valor de hPa desde el TextBox
                double hPa = double.Parse(tboxHPa.Text);

                // Convertir hPa a pulgadas de mercurio (inHg)
                double inHg = hPa * 0.029529983071445;

                // Mostrar el resultado
                tboxPulgHg.Text = inHg.ToString("F2");
                lblError.Text = "";

            }
            catch (FormatException)
            {
                // Manejar el error si el valor ingresado no es un número válido
                lblError.Text = "Ingrese un valor válido en hPa.";
            }



        }

       
    }
}
