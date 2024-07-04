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
    public partial class Cronometro : Form
    {
        private int _timeElapsed;
        private bool _timerRunning;

        public Cronometro()
        {
            InitializeComponent();
            lblTiempo.Text = "00:00:00";
            TmrReloj.Interval = 1000;
            TmrReloj.Enabled = false;
        }

        private void TmrReloj_Tick(object sender, EventArgs e)
        {
            _timeElapsed++;

            if (_timeElapsed != 0 && _timeElapsed % 60 == 0)
            {
                Console.Beep(1000, 500);
            }

            lblTiempo.Text = TimeSpan.FromSeconds(_timeElapsed).ToString(@"hh\:mm\:ss");
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            //Form1 NuevaVentana = new Form1();
            //NuevaVentana.Show();


        }


        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (_timerRunning)
            {
                TmrReloj.Enabled = false;
                _timerRunning = false;
                btnStart.Text = "Start";
            }
            else
            {
                TmrReloj.Enabled = true;
                _timerRunning = true;
                btnStart.Text = "Stop";
            }

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            _timeElapsed = 0;
            lblTiempo.Text = "00:00:00";
        }
    }
}
