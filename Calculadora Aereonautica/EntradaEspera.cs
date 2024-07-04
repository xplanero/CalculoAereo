using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Aereonautica_
{
    public partial class EntradaEspera : Form
    {
        public EntradaEspera()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //Seleccionamos espera por defecto estandar
            chklbTipoEspera.SetItemChecked(0, true);
            tboxOutbound.Text = "";
            tboxInbound.Text = "180";
            tboxHeading.Text = "180";


        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal Ventana_form1 = new Principal();
            //Ventana_form1.Show();

            Ventana_form1.ShowDialog();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tboxOutbound.Text = "";
            tboxInbound.Text = "";
            tboxHeading.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //*****************************************************




            int Outbound = 0;
            int Inbound = 0;
            if (tboxInbound.Text != "")
            {
                Inbound = int.Parse(tboxInbound.Text);
                if (Inbound >= 180)
                {
                    Outbound = Inbound - 180;
                }
                else
                {
                    Outbound = Inbound + 180;
                }
                tboxOutbound.Text = Convert.ToString(Outbound);
            }
            else
            {
                Outbound = int.Parse(tboxOutbound.Text);
                if (Outbound >= 180)
                {
                    Inbound = Outbound - 180;
                }
                else
                {
                    Inbound = Outbound + 180;
                }
                tboxInbound.Text = Convert.ToString(Inbound);

            }


            int Heading = int.Parse(tboxHeading.Text);

            //REERENCIAMOS EL OUTBOUND A CERO PARA FACILITAR LOS CALCULOS

            int offset = 0;
            if (Outbound - Heading >= 0)
            {
                offset = Outbound - Heading;
            }
            else
            {
                offset = Outbound - Heading + 360;
            }

            //Calcular tipo de entrada
            //Esperas Estandar ******************
            int tipoEntrada; //0--> Directa  1--> Gota 2--> Paralela o falsa

            if (offset > 255 & offset < 355)
            {
                lblEstandar.Text = "Estandar Paralela";
                tipoEntrada = 2;
            }
            else
            {
                if (offset < 65 | offset >= 355)
                {
                    lblEstandar.Text = "Estandar Gota";
                    tipoEntrada = 1;
                }
                else
                {
                    lblEstandar.Text = "Estandar Directa";
                    tipoEntrada = 0;
                }
            }

            //Esperas No Estandar

            if (offset >= 295 | offset <= 5)
            {
                lblNoEstandar.Text = "No Estandar Gota";
                tipoEntrada = 1;
            }
            else
            {
                if (offset < 105 & offset > 5)
                {
                    lblNoEstandar.Text = "No Estandar Paralela";
                    tipoEntrada = 2;
                }
                else
                {
                    lblNoEstandar.Text = "No Estandar Directa";
                    tipoEntrada = 0;
                }
            }

            //--------------------------------------


            Point startPoint = new Point(250, 200);
            bool tipoEspera = chklbTipoEspera.CheckedItems.Contains(chklbTipoEspera.Items[0]);

            Inbound = int.Parse(tboxInbound.Text);

            

            dibujarEspera(startPoint, Inbound, Heading, tipoEspera);

            //int curso = int.Parse(tboxHeading.Text);

            dibujarEntrada(Heading, tipoEntrada, tipoEspera);


        }

        private void chklbTipoEspera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = chklbTipoEspera.SelectedIndex;
            if (indice != -1)
            {

                if (indice == 0)
                {
                    chklbTipoEspera.SetItemChecked(1, false);
                }
                else
                {
                    chklbTipoEspera.SetItemChecked(0, false);
                }
            }

        }

        private void dibujarEspera(Point startPoint, int cursoInbound, int Heading, bool esperaEstandard)
        {
            // Obtener el objeto Graphics del panel
            Graphics g = panelEspera.CreateGraphics();
            Pen lapiz = new Pen(Color.Honeydew, 3);
            panelEspera.CreateGraphics().Clear(panelEspera.BackColor);

            int x = 250;
            int y = 200;
            int radio = 180;

            // Dibujar el círculo
            g.DrawEllipse(lapiz, x - radio, y - radio, radio * 2, radio * 2);

            Point endPoint = FuntEndPoint(startPoint, cursoInbound, 100 );

            //MessageBox.Show($"Las coordenadas del punto son {xx} {yy}");

            // Dibujar la línea en el panel
            lapiz.Color = Color.Green;
            AdjustableArrowCap arrowCap = new AdjustableArrowCap(3, 3);
            lapiz.CustomStartCap = arrowCap;


            g.DrawLine(lapiz, startPoint, endPoint);


            //***********************************************************
            //private (Point , Point) FuntLineaParalela(Point startPoint, Point endPoint, int cursoInbound, bool esperaEstandard)

            (Point parallelStart, Point parallelEnd) = FuntLineaParalela(startPoint, endPoint, cursoInbound, esperaEstandard);

            // 7. Dibujar la línea paralela

            Pen lapiz2 = new Pen(Color.Green, 3);
            AdjustableArrowCap arrowCap2 = new AdjustableArrowCap(3, 3);
            lapiz2.CustomEndCap = arrowCap2;

            g.DrawLine(lapiz2, parallelStart, parallelEnd);


            //****************************************************

            Pen lapiz3 = new Pen(Color.Green, 3);

            if (esperaEstandard)
            {
                DibujarArcoDosPuntos(g, lapiz3, startPoint, parallelStart);
                DibujarArcoDosPuntos(g, lapiz3, parallelEnd, endPoint);
            }
            else
            {
                DibujarArcoDosPuntos(g, lapiz3, parallelStart, startPoint);
                DibujarArcoDosPuntos(g, lapiz3, endPoint, parallelEnd);
            }
            
            
            //******************************************************
            //Dibujar entrada
            //dibjar linea de la entrada directo al fijo
            Pen lapiz4 = new Pen(Color.Aqua, 3);
            lapiz4.DashStyle = DashStyle.Dash;
            Point CursoEndPoint = FuntEndPoint(startPoint, Heading, 180);
            g.DrawLine(lapiz4, startPoint, CursoEndPoint);

            //libera recursos
            g.Dispose();

        }



        //*****************************************************


        private void DibujarArcoDosPuntos(Graphics g, Pen p, Point startPoint, Point endPoint)
        {

            // Calculamos el radio
            int radius = (int)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2)) / 2;

            // Calculamos el centro del arco
            Point center = new Point((startPoint.X + endPoint.X) / 2, (startPoint.Y + endPoint.Y) / 2);

            // Definimos los ángulos de inicio y final del arco
            double startAngle = Math.Atan2(startPoint.Y - center.Y, startPoint.X - center.X) * 180 / Math.PI;
            double endAngle = Math.Atan2(endPoint.Y - center.Y, endPoint.X - center.X) * 180 / Math.PI;

            // Dibujamos el arco en sentido de las agujas del reloj




            g.DrawArc(p, center.X - radius, center.Y - radius, radius * 2, radius * 2, (float)startAngle, Math.Abs((float)(endAngle - startAngle)));





        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación de forma normal, permitiendo que se realice la limpieza necesaria

            Application.Exit();

            // O cierra la aplicación abruptamente sin realizar ninguna limpieza
            // Environment.Exit(0);
        }

        private void dibujarEntrada(int curso, int tipoEntrada, bool tipoEspera)
        {
            //Dibujar la línea hasta el fijo

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private Point FuntEndPoint(Point startPoint, int cursoInbound, int length)
        {
            //Sumamos 90 grados para que la línea coincida con el curso INBOUND
            int angle = cursoInbound + 90;

            if (angle > 360)
            {
                angle = angle - 360;
            }
            // Convertir el ángulo de grados a radianes
            double radians = angle * Math.PI / 180.0;


            // Calcular las coordenadas del punto final de la línea
            double x = startPoint.X + length * Math.Cos(radians);
            double y = startPoint.Y + length * Math.Sin(radians);
            x = Math.Round(x);
            y = Math.Round(y);

            Point endPoint = new Point((int)x, (int)y);

            return endPoint;
        }

        private (Point , Point) FuntLineaParalela(Point startPoint, Point endPoint, int cursoInbound, bool esperaEstandard)
        {

            //************************************
            //*******Dibjar linea paralela********
            //************************************

            //Separación negativa para espera estandar
            int separation = -70;
            if (!esperaEstandard)
            {
                separation = 70;
            }

            //Calculo del primer punto de la línea
            //90 grados del ángulo de la primera línea


            cursoInbound = cursoInbound + 180;
            if (cursoInbound > 360)
            {
                cursoInbound = cursoInbound - 360;
            }
            // Convertir el ángulo de grados a radianes
            double radians = cursoInbound * Math.PI / 180.0;

            // Calcular las coordenadas del punto inicial de la línea paralela
            double x1p = startPoint.X + separation * Math.Cos(radians);
            double y1p = startPoint.Y + separation * Math.Sin(radians);
            Point parallelStart = new Point((int)x1p, (int)y1p);

            // Calcular las coordenadas del punto final de la línea paralela
            double x2p = endPoint.X + separation * Math.Cos(radians);
            double y2p = endPoint.Y + separation * Math.Sin(radians);
            Point parallelEnd = new Point((int)x2p, (int)y2p);



            return (parallelStart, parallelEnd);
        }
    }
}
