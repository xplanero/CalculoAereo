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
    public partial class AscensosDescensos : Form
    {
        public AscensosDescensos()
        {
            InitializeComponent();

            tboxAltitudInicial.Text = "11000";
            tboxAltitudFinal.Text = "0700";
            tboxGS.Text = "180";
            tboxVV.Text = "500";

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }



        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tboxAltitudInicial.Text = "";
            tboxAltitudFinal.Text = "";
            tboxGS.Text = "";
            tboxVV.Text = "";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double AltitudInicial = Int32.Parse(tboxAltitudInicial.Text);
            double AltitudFinal = Int32.Parse(tboxAltitudFinal.Text);
            double GS = Int32.Parse(tboxGS.Text);
            double VV = Int32.Parse(tboxVV.Text);

            double deltaAltitud = (AltitudInicial - AltitudFinal);

            deltaAltitud = Math.Abs(deltaAltitud);

            double tiempo = deltaAltitud / VV;

            double distancia = GS * tiempo / 60;

            tiempo = Math.Round(tiempo, 2, MidpointRounding.ToEven);

            distancia = Math.Round(distancia, 2, MidpointRounding.ToEven);

            lblTiempo.Text = "Tiempo " + tiempo + " min";
            lblDistancia.Text = distancia + " NM";



        }


        private void Form3_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            // Si se pulsa en la "X" en la esquina superior derecha
            // de la ventana, se cierra la aplicación

            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = false;
                Application.Exit();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 Ventana_form1 = new Form1();
            //Ventana_form1.Show();



        }

       
    }

}
