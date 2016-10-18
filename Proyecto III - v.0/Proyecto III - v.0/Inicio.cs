using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_III___v._0
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button_Crear_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(1);
            menu.Show();
            //this.Close();
        }

        private void button_Unirse_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal(2);
            menu.Show();
            //this.Close();
            MenuPrincipal.
        }

    }
}
