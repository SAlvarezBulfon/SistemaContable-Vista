namespace Sistema_Contable.Vista
{
    partial class Haber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Haber));
            panel1 = new Panel();
            btnClose = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            btnGuardar = new Button();
            label2 = new Label();
            tbMonto = new TextBox();
            label1 = new Label();
            label3 = new Label();
            cbCuenta = new ComboBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 62, 80);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(5, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 37);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(230, 57, 70);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(493, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(35, 35);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Left;
            panel2.ForeColor = SystemColors.ControlText;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 301);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(528, 37);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 259);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 62, 80);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(5, 296);
            panel4.Name = "panel4";
            panel4.Size = new Size(528, 5);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(69, 123, 157);
            panel5.Controls.Add(btnGuardar);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(tbMonto);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(cbCuenta);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(5, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(528, 296);
            panel5.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(29, 53, 87);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Lato Semibold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.FromArgb(241, 250, 238);
            btnGuardar.Location = new Point(196, 234);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 40);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 250, 238);
            label2.Location = new Point(224, 56);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 7;
            label2.Text = "HABER";
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(60, 184);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(419, 23);
            tbMonto.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato Semibold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 250, 238);
            label1.Location = new Point(60, 79);
            label1.Name = "label1";
            label1.Size = new Size(61, 19);
            label1.TabIndex = 6;
            label1.Text = "Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lato Semibold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(241, 250, 238);
            label3.Location = new Point(60, 150);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 9;
            label3.Text = "Monto";
            // 
            // cbCuenta
            // 
            cbCuenta.FormattingEnabled = true;
            cbCuenta.Location = new Point(60, 113);
            cbCuenta.Name = "cbCuenta";
            cbCuenta.Size = new Size(419, 23);
            cbCuenta.TabIndex = 8;
            // 
            // Haber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 301);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Haber";
            Text = "Haber";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label2;
        public TextBox tbMonto;
        private Label label1;
        private Label label3;
        public ComboBox cbCuenta;
        public Button btnClose;
        public Button btnGuardar;
    }
}