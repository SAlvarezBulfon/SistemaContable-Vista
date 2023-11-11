using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Contable.Vista
{
    public partial class DiarioView : Form
    {
        public DiarioView()
        {

            InitializeComponent();
        }

        private void btnDebe_Click(object sender, EventArgs e)
        {
            Debe debe = new Debe();
            debe.StartPosition = FormStartPosition.CenterScreen;
            debe.Show();
        }

        private void btnHaber_Click(object sender, EventArgs e)
        {

            Haber haber = new Haber();
            haber.StartPosition = FormStartPosition.CenterScreen;
            haber.Show();
        }
    }
}
