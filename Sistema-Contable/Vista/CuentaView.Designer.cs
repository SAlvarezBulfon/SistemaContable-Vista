namespace Sistema_Contable.Vista
{
    partial class CuentaView
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
            button1 = new Button();
            dgCuentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgCuentas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(241, 250, 238);
            label1.Location = new Point(27, 24);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 0;
            label1.Text = "PLAN DE CUENTA";
            // 
            // btnDebe
            // 
            btnDebe.BackColor = Color.FromArgb(168, 218, 220);
            btnDebe.FlatAppearance.BorderSize = 0;
            btnDebe.FlatStyle = FlatStyle.Flat;
            btnDebe.Font = new Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDebe.ForeColor = Color.FromArgb(51, 62, 80);
            btnDebe.Location = new Point(27, 73);
            btnDebe.Name = "btnDebe";
            btnDebe.Size = new Size(75, 31);
            btnDebe.TabIndex = 3;
            btnDebe.Text = "Añadir";
            btnDebe.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(230, 57, 70);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lato", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(241, 250, 238);
            button1.Location = new Point(123, 73);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 4;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // dgCuentas
            // 
            dgCuentas.BackgroundColor = Color.FromArgb(241, 250, 238);
            dgCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCuentas.Location = new Point(29, 124);
            dgCuentas.Name = "dgCuentas";
            dgCuentas.RowTemplate.Height = 25;
            dgCuentas.Size = new Size(784, 284);
            dgCuentas.TabIndex = 5;
            // 
            // CuentaView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 123, 157);
            ClientSize = new Size(835, 433);
            Controls.Add(dgCuentas);
            Controls.Add(button1);
            Controls.Add(btnDebe);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CuentaView";
            Text = "CuentaView";
            ((System.ComponentModel.ISupportInitialize)dgCuentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Button btnDebe;
        public Button button1;
        private DataGridView dgCuentas;
    }
}