namespace Calculadora_Aereonautica_
{
    partial class Cronometro
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cronometro));
            btnMenu = new Button();
            TmrReloj = new System.Windows.Forms.Timer(components);
            btnStart = new Button();
            btnReset = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(196, 114);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 17;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // TmrReloj
            // 
            TmrReloj.Interval = 1000;
            TmrReloj.Tick += TmrReloj_Tick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 78);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 19;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click_1;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(118, 78);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click_1;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiempo.ForeColor = Color.DarkSlateBlue;
            lblTiempo.Location = new Point(71, 30);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(94, 28);
            lblTiempo.TabIndex = 22;
            lblTiempo.Text = "00:00:00";
            // 
            // Cronometro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 165);
            Controls.Add(lblTiempo);
            Controls.Add(btnReset);
            Controls.Add(btnStart);
            Controls.Add(btnMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Cronometro";
            Text = "Cronómetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private System.Windows.Forms.Timer TmrReloj;
        private Button btnStart;
        private Button btnReset;
        private Label lblTiempo;
    }
}