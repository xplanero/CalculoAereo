namespace Calculadora_Aereonautica_
{
    partial class UnidadPresion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadPresion));
            lblHPa = new Label();
            tboxHPa = new TextBox();
            lblHg = new Label();
            tboxPulgHg = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnMenu = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblHPa
            // 
            lblHPa.AutoSize = true;
            lblHPa.Location = new Point(10, 15);
            lblHPa.Name = "lblHPa";
            lblHPa.Size = new Size(27, 15);
            lblHPa.TabIndex = 1;
            lblHPa.Text = "hPa";
            // 
            // tboxHPa
            // 
            tboxHPa.Location = new Point(43, 12);
            tboxHPa.Name = "tboxHPa";
            tboxHPa.Size = new Size(79, 23);
            tboxHPa.TabIndex = 2;
            // 
            // lblHg
            // 
            lblHg.AutoSize = true;
            lblHg.Location = new Point(9, 49);
            lblHg.Name = "lblHg";
            lblHg.Size = new Size(28, 15);
            lblHg.TabIndex = 3;
            lblHg.Text = "\"Hg";
            // 
            // tboxPulgHg
            // 
            tboxPulgHg.Location = new Point(43, 46);
            tboxPulgHg.Name = "tboxPulgHg";
            tboxPulgHg.Size = new Size(79, 23);
            tboxPulgHg.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(43, 96);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(43, 134);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(172, 134);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 7;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(128, 20);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 8;
            // 
            // UnidadPresion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 180);
            Controls.Add(lblError);
            Controls.Add(btnMenu);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(tboxPulgHg);
            Controls.Add(lblHg);
            Controls.Add(tboxHPa);
            Controls.Add(lblHPa);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UnidadPresion";
            Text = "HectoPascales/PulgadasHg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblHPa;
        private TextBox tboxHPa;
        private Label lblHg;
        private TextBox tboxPulgHg;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnMenu;
        private Label lblError;
    }
}