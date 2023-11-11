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
    public partial class Debe : Form
    {
        public Debe()
        {
            InitializeComponent();
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
