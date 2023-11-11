namespace Sistema_Contable.Vista
{
    partial class DiarioView
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
            label1 = new Label();
            btnDebe = new Button();
            btnHaber = new Button();
            label2 = new Label();
            dgAsientos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgAsientos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 250, 238);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 1;
            label1.Text = "Cargar Asiento";
            // 
            // btnDebe
            // 
            btnDebe.BackColor = Color.FromArgb(168, 218, 220);
            btnDebe.FlatAppearance.BorderSize = 0;
            btnDebe.FlatStyle = FlatStyle.Flat;
            btnDebe.Font = new Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDebe.ForeColor = Color.FromArgb(51, 62, 80);
            btnDebe.Location = new Point(38, 46);
            btnDebe.Name = "btnDebe";
            btnDebe.Size = new Size(75, 31);
            btnDebe.TabIndex = 2;
            btnDebe.Text = "Debe";
            btnDebe.UseVisualStyleBackColor = false;
            btnDebe.Click += btnDebe_Click;
            // 
            // btnHaber
            // 
            btnHaber.BackColor = Color.FromArgb(168, 218, 220);
            btnHaber.FlatAppearance.BorderSize = 0;
            btnHaber.FlatStyle = FlatStyle.Flat;
            btnHaber.Font = new Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHaber.ForeColor = Color.FromArgb(51, 62, 80);
            btnHaber.Location = new Point(132, 46);
            btnHaber.Name = "btnHaber";
            btnHaber.Size = new Size(75, 31);
            btnHaber.TabIndex = 3;
            btnHaber.Text = "Haber";
            btnHaber.UseVisualStyleBackColor = false;
            btnHaber.Click += btnHaber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lato Semibold", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(241, 250, 238);
            label2.Location = new Point(38, 98);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 4;
            label2.Text = "Asientos";
            // 
            // dgAsientos
            // 
            dgAsientos.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgAsientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAsientos.Location = new Point(38, 131);
            dgAsientos.Name = "dgAsientos";
            dgAsientos.RowTemplate.Height = 25;
            dgAsientos.Size = new Size(766, 276);
            dgAsientos.TabIndex = 5;
            // 
            // DiarioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 123, 157);
            ClientSize = new Size(835, 433);
            Controls.Add(dgAsientos);
            Controls.Add(label2);
            Controls.Add(btnHaber);
            Controls.Add(btnDebe);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiarioView";
            Text = "DiarioView";
            ((System.ComponentModel.ISupportInitialize)dgAsientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public Button btnDebe;
        public Button btnHaber;
        public DataGridView dgAsientos;
    }
}