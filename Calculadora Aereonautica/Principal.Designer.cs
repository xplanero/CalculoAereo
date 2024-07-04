namespace Calculadora_Aereonautica_
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnEsperas = new Button();
            btnAsc_Desc = new Button();
            btnCronómetro = new Button();
            btnSalir = new Button();
            btnhPa = new Button();
            PlanVuelo = new Button();
            SuspendLayout();
            // 
            // btnEsperas
            // 
            btnEsperas.Location = new Point(23, 17);
            btnEsperas.Name = "btnEsperas";
            btnEsperas.Size = new Size(75, 23);
            btnEsperas.TabIndex = 0;
            btnEsperas.Text = "Esperas";
            btnEsperas.UseVisualStyleBackColor = true;
            btnEsperas.Click += btnEsperas_Click;
            // 
            // btnAsc_Desc
            // 
            btnAsc_Desc.Location = new Point(23, 46);
            btnAsc_Desc.Name = "btnAsc_Desc";
            btnAsc_Desc.Size = new Size(75, 23);
            btnAsc_Desc.TabIndex = 1;
            btnAsc_Desc.Text = "Descensos";
            btnAsc_Desc.UseVisualStyleBackColor = true;
            btnAsc_Desc.Click += btnAsc_Desc_Click;
            // 
            // btnCronómetro
            // 
            btnCronómetro.Location = new Point(23, 75);
            btnCronómetro.Name = "btnCronómetro";
            btnCronómetro.Size = new Size(75, 23);
            btnCronómetro.TabIndex = 2;
            btnCronómetro.Text = "Crono";
            btnCronómetro.UseVisualStyleBackColor = true;
            btnCronómetro.Click += btnCronómetro_Click;
            // 
            // btnSalir
            // 
            btnSalir.DialogResult = DialogResult.Cancel;
            btnSalir.Location = new Point(304, 163);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnhPa
            // 
            btnhPa.Location = new Point(23, 104);
            btnhPa.Name = "btnhPa";
            btnhPa.Size = new Size(75, 23);
            btnhPa.TabIndex = 4;
            btnhPa.Text = "hPa/Hg";
            btnhPa.UseVisualStyleBackColor = true;
            btnhPa.Click += btnhPa_Click;
            // 
            // PlanVuelo
            // 
            PlanVuelo.Location = new Point(23, 133);
            PlanVuelo.Name = "PlanVuelo";
            PlanVuelo.Size = new Size(75, 23);
            PlanVuelo.TabIndex = 5;
            PlanVuelo.Text = "PlanVuelo";
            PlanVuelo.UseVisualStyleBackColor = true;
            PlanVuelo.Click += this.PlanVuelo_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 211);
            Controls.Add(PlanVuelo);
            Controls.Add(btnhPa);
            Controls.Add(btnSalir);
            Controls.Add(btnCronómetro);
            Controls.Add(btnAsc_Desc);
            Controls.Add(btnEsperas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Aeronaútica";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEsperas;
        private Button btnAsc_Desc;
        private Button btnCronómetro;
        private Button btnSalir;
        private Button btnhPa;
        private Button PlanVuelo;
    }
}