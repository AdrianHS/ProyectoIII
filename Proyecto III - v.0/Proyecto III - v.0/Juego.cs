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
    public partial class Juego : Form
    {
        public Juego(int dificultad)
        {
            InitializeComponent();
            cargar(dificultad);
        }

        public void cargar(int tamano)
        {
            if (tamano == 5)
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "dfsadf";
                        tableLayoutPanel_AliadoFacil.Controls.Add(a);
                    }
                }
                tableLayoutPanel_AliadoDificil.Visible = false;
                tableLayoutPanel_AliadoMedio.Visible = false;
            }
            else if (tamano == 10)
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "dfsadf";
                        tableLayoutPanel_AliadoMedio.Controls.Add(a);
                    }
                }
                tableLayoutPanel_AliadoFacil.Visible = false;
                tableLayoutPanel_AliadoDificil.Visible = false;
            }
            else 
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "dfsadf";
                        tableLayoutPanel_AliadoDificil.Controls.Add(a);
                    }
                }
                tableLayoutPanel_AliadoFacil.Visible = false;
                tableLayoutPanel_AliadoMedio.Visible = false;
            }
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Aliado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_Enemigo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_AliadoFacil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel_AlidadoMedio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
