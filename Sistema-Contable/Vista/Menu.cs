using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Contable
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Panel p = new Panel();
        public void btnMouseEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            pMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(90, 210, 2);
            p.Size = new Size(140, 5);
            p.Location = new Point(btn.Location.X, btn.Location.Y + 40);
        }

        public void btnMouseLeave(object sender, EventArgs e)
        {
            pMenu.Controls.Remove(p);
        }
    }
}