namespace Calculadora_Aereonautica_
{
    partial class EntradaEspera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaEspera));
            lblOutbound = new Label();
            lblInbound = new Label();
            lblHeading = new Label();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            tboxHeading = new TextBox();
            tboxInbound = new TextBox();
            tboxOutbound = new TextBox();
            lblEstandar = new Label();
            lblNoEstandar = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnMenu = new Button();
            panelEspera = new Panel();
            chklbTipoEspera = new CheckedListBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblOutbound
            // 
            lblOutbound.AutoSize = true;
            lblOutbound.Location = new Point(12, 106);
            lblOutbound.Name = "lblOutbound";
            lblOutbound.Size = new Size(62, 15);
            lblOutbound.TabIndex = 5;
            lblOutbound.Text = "Outbound";
            // 
            // lblInbound
            // 
            lblInbound.AutoSize = true;
            lblInbound.Location = new Point(22, 62);
            lblInbound.Name = "lblInbound";
            lblInbound.Size = new Size(52, 15);
            lblInbound.TabIndex = 4;
            lblInbound.Text = "Inbound";
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(22, 25);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(52, 15);
            lblHeading.TabIndex = 3;
            lblHeading.Text = "Heading";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(89, 202);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(89, 240);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // tboxHeading
            // 
            tboxHeading.Location = new Point(89, 25);
            tboxHeading.Name = "tboxHeading";
            tboxHeading.Size = new Size(100, 23);
            tboxHeading.TabIndex = 8;
            tboxHeading.Text = "0";
            // 
            // tboxInbound
            // 
            tboxInbound.Location = new Point(89, 62);
            tboxInbound.Name = "tboxInbound";
            tboxInbound.Size = new Size(100, 23);
            tboxInbound.TabIndex = 9;
            // 
            // tboxOutbound
            // 
            tboxOutbound.Location = new Point(89, 98);
            tboxOutbound.Name = "tboxOutbound";
            tboxOutbound.Size = new Size(100, 23);
            tboxOutbound.TabIndex = 10;
            // 
            // lblEstandar
            // 
            lblEstandar.AutoSize = true;
            lblEstandar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblEstandar.Location = new Point(223, 28);
            lblEstandar.Name = "lblEstandar";
            lblEstandar.Size = new Size(54, 15);
            lblEstandar.TabIndex = 11;
            lblEstandar.Text = "Estandar";
            // 
            // lblNoEstandar
            // 
            lblNoEstandar.AutoSize = true;
            lblNoEstandar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNoEstandar.Location = new Point(223, 65);
            lblNoEstandar.Name = "lblNoEstandar";
            lblNoEstandar.Size = new Size(74, 15);
            lblNoEstandar.TabIndex = 12;
            lblNoEstandar.Text = "No estandar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 98);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 13;
            label3.Text = "Introduce el Heading y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 113);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 14;
            label4.Text = "Outbound o Inbound";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(223, 128);
            label5.Name = "label5";
            label5.Size = new Size(93, 15);
            label5.TabIndex = 15;
            label5.Text = "y pulsa Calcular.";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(268, 176);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 16;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panelEspera
            // 
            panelEspera.BorderStyle = BorderStyle.FixedSingle;
            panelEspera.Location = new Point(366, 12);
            panelEspera.Name = "panelEspera";
            panelEspera.Size = new Size(500, 400);
            panelEspera.TabIndex = 17;
            // 
            // chklbTipoEspera
            // 
            chklbTipoEspera.CheckOnClick = true;
            chklbTipoEspera.FormattingEnabled = true;
            chklbTipoEspera.Items.AddRange(new object[] { "Estandard", "No estandar" });
            chklbTipoEspera.Location = new Point(89, 139);
            chklbTipoEspera.Name = "chklbTipoEspera";
            chklbTipoEspera.Size = new Size(101, 40);
            chklbTipoEspera.TabIndex = 18;
            chklbTipoEspera.SelectedIndexChanged += chklbTipoEspera_SelectedIndexChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(268, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 19;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // EntradaEspera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 423);
            Controls.Add(btnSalir);
            Controls.Add(chklbTipoEspera);
            Controls.Add(panelEspera);
            Controls.Add(btnMenu);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblNoEstandar);
            Controls.Add(lblEstandar);
            Controls.Add(tboxOutbound);
            Controls.Add(tboxInbound);
            Controls.Add(tboxHeading);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(lblOutbound);
            Controls.Add(lblInbound);
            Controls.Add(lblHeading);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EntradaEspera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entrada en espera.";
            FormClosing += Form2_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutbound;
        private Label lblInbound;
        private Label lblHeading;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox tboxHeading;
        private TextBox tboxInbound;
        private TextBox tboxOutbound;
        private Label lblEstandar;
        private Label lblNoEstandar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnMenu;
        private Panel panelEspera;
        private CheckedListBox chklbTipoEspera;
        private Button btnSalir;
    }
}