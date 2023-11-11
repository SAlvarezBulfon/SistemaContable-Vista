namespace Sistema_Contable.Vista
{
    partial class InicioView
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
            dgDiario = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDiario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 250, 238);
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "DIARIO";
            // 
            // dgDiario
            // 
            dgDiario.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDiario.Location = new Point(24, 60);
            dgDiario.Name = "dgDiario";
            dgDiario.RowTemplate.Height = 25;
            dgDiario.Size = new Size(785, 350);
            dgDiario.TabIndex = 1;
            // 
            // InicioView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 123, 157);
            ClientSize = new Size(835, 433);
            Controls.Add(dgDiario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InicioView";
            Text = "InicioView";
            ((System.ComponentModel.ISupportInitialize)dgDiario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public DataGridView dgDiario;
        private DataGridView dataGridView1;
    }
}