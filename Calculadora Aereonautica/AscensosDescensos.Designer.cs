namespace Calculadora_Aereonautica_
{
    partial class AscensosDescensos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AscensosDescensos));
            btnMenu = new Button();
            lblAltituInicial = new Label();
            lblAltitudFinal = new Label();
            lblGS = new Label();
            lblVV = new Label();
            tboxAltitudInicial = new TextBox();
            tboxAltitudFinal = new TextBox();
            tboxGS = new TextBox();
            tboxVV = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblTiempo = new Label();
            lblDistancia = new Label();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(343, 226);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 17;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblAltituInicial
            // 
            lblAltituInicial.AutoSize = true;
            lblAltituInicial.Location = new Point(37, 22);
            lblAltituInicial.Name = "lblAltituInicial";
            lblAltituInicial.Size = new Size(77, 15);
            lblAltituInicial.TabIndex = 18;
            lblAltituInicial.Text = "Altitud inicial";
            // 
            // lblAltitudFinal
            // 
            lblAltitudFinal.AutoSize = true;
            lblAltitudFinal.Location = new Point(45, 51);
            lblAltitudFinal.Name = "lblAltitudFinal";
            lblAltitudFinal.Size = new Size(69, 15);
            lblAltitudFinal.TabIndex = 19;
            lblAltitudFinal.Text = "Altitud final";
            // 
            // lblGS
            // 
            lblGS.AutoSize = true;
            lblGS.Location = new Point(33, 83);
            lblGS.Name = "lblGS";
            lblGS.Size = new Size(81, 15);
            lblGS.TabIndex = 20;
            lblGS.Text = "Ground speed";
            // 
            // lblVV
            // 
            lblVV.AutoSize = true;
            lblVV.Location = new Point(15, 112);
            lblVV.Name = "lblVV";
            lblVV.Size = new Size(99, 15);
            lblVV.TabIndex = 21;
            lblVV.Text = "Velocidad vertical";
            // 
            // tboxAltitudInicial
            // 
            tboxAltitudInicial.Location = new Point(120, 19);
            tboxAltitudInicial.Name = "tboxAltitudInicial";
            tboxAltitudInicial.Size = new Size(100, 23);
            tboxAltitudInicial.TabIndex = 22;
            // 
            // tboxAltitudFinal
            // 
            tboxAltitudFinal.Location = new Point(120, 48);
            tboxAltitudFinal.Name = "tboxAltitudFinal";
            tboxAltitudFinal.Size = new Size(100, 23);
            tboxAltitudFinal.TabIndex = 23;
            // 
            // tboxGS
            // 
            tboxGS.Location = new Point(120, 80);
            tboxGS.Name = "tboxGS";
            tboxGS.Size = new Size(100, 23);
            tboxGS.TabIndex = 24;
            // 
            // tboxVV
            // 
            tboxVV.Location = new Point(120, 109);
            tboxVV.Name = "tboxVV";
            tboxVV.Size = new Size(100, 23);
            tboxVV.TabIndex = 25;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(129, 176);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 27;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(129, 138);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiempo.Location = new Point(237, 48);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(49, 15);
            lblTiempo.TabIndex = 28;
            lblTiempo.Text = "Tiempo";
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDistancia.Location = new Point(263, 83);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(57, 15);
            lblDistancia.TabIndex = 29;
            lblDistancia.Text = "Distancia";
            // 
            // AscensosDescensos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 261);
            Controls.Add(lblDistancia);
            Controls.Add(lblTiempo);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(tboxVV);
            Controls.Add(tboxGS);
            Controls.Add(tboxAltitudFinal);
            Controls.Add(tboxAltitudInicial);
            Controls.Add(lblVV);
            Controls.Add(lblGS);
            Controls.Add(lblAltitudFinal);
            Controls.Add(lblAltituInicial);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AscensosDescensos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ascensos y descensos.";
            FormClosing += Form3_FormClosing_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Label lblAltituInicial;
        private Label lblAltitudFinal;
        private Label lblGS;
        private Label lblVV;
        private TextBox tboxAltitudInicial;
        private TextBox tboxAltitudFinal;
        private TextBox tboxGS;
        private TextBox tboxVV;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblTiempo;
        private Label lblDistancia;
    }
}