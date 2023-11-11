using Sistema_Contable.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Contable.Controlador
{
    internal class MenuController
    {
        private Menu menu;
        private Form vistaActual;



        public MenuController()
        {
            menu = new Menu();

            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.btnClose.Click += BtnClose_Click;
            //Comienza siempre con Inicio
            MostrarVista(typeof(InicioView));
            menu.btnInicio.Click += (sender, e) => MostrarVista(typeof(InicioView));
            menu.btnDiario.Click += (sender, e) => MostrarVista(typeof(DiarioView));
            menu.btnCuenta.Click += (sender, e) => MostrarVista(typeof(CuentaView));
            menu.btnMayor.Click += (sender, e) => MostrarVista(typeof(MayorView));

        }

        public void Run()
        {
            menu.ShowDialog();
        }

        public void BtnClose_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        public void MostrarVista(Type tipoVista)
        {
            if (vistaActual != null)
            {
                vistaActual.Close();
            }

            var vista = (Form)Activator.CreateInstance(tipoVista);
            vista.TopLevel = false;
            menu.PContent.Controls.Add(vista);
            vista.Show();
            vistaActual = vista;
        }

    }

}
