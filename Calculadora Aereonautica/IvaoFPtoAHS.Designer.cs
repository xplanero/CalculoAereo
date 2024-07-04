namespace Calculadora_Aereonautica_
{
    partial class IvaoFPtoAHS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IvaoFPtoAHS));
            Seleccionar = new Button();
            Destino = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // Seleccionar
            // 
            Seleccionar.Location = new Point(12, 12);
            Seleccionar.Name = "Seleccionar";
            Seleccionar.Size = new Size(75, 23);
            Seleccionar.TabIndex = 0;
            Seleccionar.Text = "Seleccionar";
            Seleccionar.UseVisualStyleBackColor = true;
            Seleccionar.Click += Seleccionar_Click;
            // 
            // Destino
            // 
            Destino.Location = new Point(12, 41);
            Destino.Name = "Destino";
            Destino.Size = new Size(75, 23);
            Destino.TabIndex = 1;
            Destino.Text = "Destino";
            Destino.UseVisualStyleBackColor = true;
            Destino.Click += Destino_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(210, 73);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 2;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // IvaoFPtoAHS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 121);
            Controls.Add(btnMenu);
            Controls.Add(Destino);
            Controls.Add(Seleccionar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IvaoFPtoAHS";
            Text = "Plan de vuelo IVAO a AHS";
            Load += IvaoFPtoAHS_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Seleccionar;
        private Button Destino;
        private Button btnMenu;
    }
}