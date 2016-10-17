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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("Path", @"C:\Program Files (x86)\swipl\bin");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dificultad;
            string dif;
            dif = comboBoxDificultad.Text;
            if (dif == "Facil")
                dificultad = 5;
            else if (dif == "Medio")
                dificultad = 10;
            else
                dificultad = 15;
            Juego juego = new Juego(dificultad);
            juego.Show();
            

        }
    }
}
