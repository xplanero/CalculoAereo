namespace Calculadora_Aereonautica_
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
       

        private void btnEsperas_Click(object sender, EventArgs e)
        {
            this.Hide();
            EntradaEspera NuevaVentana = new EntradaEspera();
            NuevaVentana.ShowDialog();
        }

        private void btnAsc_Desc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AscensosDescensos NuevaVentana = new AscensosDescensos();
            NuevaVentana.ShowDialog();

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación de forma normal, permitiendo que se realice la limpieza necesaria

            Application.Exit();

            // O cierra la aplicación abruptamente sin realizar ninguna limpieza
            // Environment.Exit(0);
        }

        private void btnCronómetro_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Cronometro NuevaVentana = new Cronometro();
            NuevaVentana.ShowDialog();
        }

        private void btnhPa_Click(object sender, EventArgs e)
        {
            UnidadPresion NuevaVentana = new UnidadPresion();
            NuevaVentana.ShowDialog();
        }

        private void PlanVuelo_Click(object sender, EventArgs e)
        {
            IvaoFPtoAHS NuevaVentana = new IvaoFPtoAHS();
            NuevaVentana.ShowDialog();
        }
    }

}