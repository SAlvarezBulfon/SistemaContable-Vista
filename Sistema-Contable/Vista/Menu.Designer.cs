namespace Sistema_Contable
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pMenu = new Panel();
            btnCuenta = new Button();
            btnMayor = new Button();
            btnDiario = new Button();
            btnInicio = new Button();
            btnClose = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            PContent = new Panel();
            pMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.FromArgb(51, 62, 80);
            pMenu.Controls.Add(btnCuenta);
            pMenu.Controls.Add(btnMayor);
            pMenu.Controls.Add(btnDiario);
            pMenu.Controls.Add(btnInicio);
            pMenu.Controls.Add(btnClose);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(845, 45);
            pMenu.TabIndex = 0;
            // 
            // btnCuenta
            // 
            btnCuenta.Cursor = Cursors.Hand;
            btnCuenta.FlatAppearance.BorderSize = 0;
            btnCuenta.FlatStyle = FlatStyle.Flat;
            btnCuenta.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnCuenta.ForeColor = Color.White;
            btnCuenta.Location = new Point(557, 0);
            btnCuenta.Name = "btnCuenta";
            btnCuenta.Size = new Size(140, 40);
            btnCuenta.TabIndex = 4;
            btnCuenta.Text = "Plan de Cuenta";
            btnCuenta.UseVisualStyleBackColor = true;
            btnCuenta.MouseEnter += btnMouseEnter;
            btnCuenta.MouseLeave += btnMouseLeave;
            // 
            // btnMayor
            // 
            btnMayor.Cursor = Cursors.Hand;
            btnMayor.FlatAppearance.BorderSize = 0;
            btnMayor.FlatStyle = FlatStyle.Flat;
            btnMayor.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnMayor.ForeColor = Color.White;
            btnMayor.Location = new Point(417, 0);
            btnMayor.Name = "btnMayor";
            btnMayor.Size = new Size(140, 40);
            btnMayor.TabIndex = 3;
            btnMayor.Text = "Mayor";
            btnMayor.UseVisualStyleBackColor = true;
            btnMayor.MouseEnter += btnMouseEnter;
            btnMayor.MouseLeave += btnMouseLeave;
            // 
            // btnDiario
            // 
            btnDiario.Cursor = Cursors.Hand;
            btnDiario.FlatAppearance.BorderSize = 0;
            btnDiario.FlatStyle = FlatStyle.Flat;
            btnDiario.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiario.ForeColor = Color.White;
            btnDiario.Location = new Point(277, 0);
            btnDiario.Name = "btnDiario";
            btnDiario.Size = new Size(140, 40);
            btnDiario.TabIndex = 2;
            btnDiario.Text = "Diario";
            btnDiario.UseVisualStyleBackColor = true;
            btnDiario.MouseEnter += btnMouseEnter;
            btnDiario.MouseLeave += btnMouseLeave;
            // 
            // btnInicio
            // 
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Lato", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(137, 0);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(140, 40);
            btnInicio.TabIndex = 1;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.MouseEnter += btnMouseEnter;
            btnInicio.MouseLeave += btnMouseLeave;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 57, 70);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(810, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 438);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(840, 45);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 438);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 62, 80);
            panel4.Dock = DockStyle.Bottom;
            panel4.ForeColor = SystemColors.ControlText;
            panel4.Location = new Point(5, 478);
            panel4.Name = "panel4";
            panel4.Size = new Size(835, 5);
            panel4.TabIndex = 3;
            // 
            // PContent
            // 
            PContent.BackColor = SystemColors.ActiveCaption;
            PContent.Dock = DockStyle.Fill;
            PContent.Location = new Point(5, 45);
            PContent.Name = "PContent";
            PContent.Size = new Size(835, 433);
            PContent.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 483);
            Controls.Add(PContent);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Sistema Contable";
            pMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        public Panel PContent;
        public Button btnClose;
        public Button btnCuenta;
        public Button btnMayor;
        public Button btnDiario;
        public Button btnInicio;
        public Panel pMenu;
    }
}