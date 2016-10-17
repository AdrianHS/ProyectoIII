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


        //Metodo que carga las matrices con el tamano deseado.
        public void cargar(int tamano)
        {
            if (tamano == 5)
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        Button b = new Button();

                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "" + i + "," + j + "";
                        a.Tag = "" + i + "," + j + "";
                        a.Name = "0";
                       

                        b.Height = 80;
                        b.Width = 80;
                        b.Margin = new System.Windows.Forms.Padding(0);
                        b.Text = "" + i + "," + j + "";
                        b.Tag = "" + i + "," + j + "";

                        if (a.Name == "0")
                            a.BackgroundImage = Image.FromFile(@"Agua.png");
                        else
                            a.BackgroundImage = Image.FromFile(@"Nada.png");

                        a.Click += (s, e) =>
                        {
                            buttonAction(a,tamano);
                        };

                       
                        tableLayoutPanel_AliadoFacil.Controls.Add(a);
                        tableLayoutPanel_EnemigoFacil.Controls.Add(b);
                    }
                }
                tableLayoutPanel_AliadoDificil.Visible = false;
                tableLayoutPanel_AliadoMedio.Visible = false;
                tableLayoutPanel_EnemigoDificil.Visible = false;
                tableLayoutPanel_EnemigoMedio.Visible = false;
            }
            else if (tamano == 10)
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        Button b = new Button();

                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "" + i + "," + j + "";
                        a.Tag = "" + i + "," + j + "";
                       
                        b.Height = 80;
                        b.Width = 80;
                        b.Margin = new System.Windows.Forms.Padding(0);
                        b.Text = "" + i + "," + j + "";
                        b.Tag = "" + i + "," + j + "";

                        tableLayoutPanel_AliadoMedio.Controls.Add(a);
                        tableLayoutPanel_EnemigoMedio.Controls.Add(b);
                    }
                }
                tableLayoutPanel_AliadoFacil.Visible = false;
                tableLayoutPanel_AliadoDificil.Visible = false;
                tableLayoutPanel_EnemigoFacil.Visible = false;
                tableLayoutPanel_EnemigoDificil.Visible = false;
            }
            else 
            {

                for (int i = 0; i < tamano; i++)

                {
                    for (int j = 0; j < tamano; j++)
                    {

                        Button a = new Button();
                        Button b = new Button();

                        a.Height = 80;
                        a.Width = 80;
                        a.Margin = new System.Windows.Forms.Padding(0);
                        a.Text = "" + i + "," + j + "";
                        a.Tag = "" + i + "," + j + "";
                        a.BackgroundImage = Image.FromFile(@"Agua.png");

                        b.Height = 80;
                        b.Width = 80;
                        b.Margin = new System.Windows.Forms.Padding(0);
                        b.Text = "" + i + "," + j + "";
                        b.Tag = "" + i + "," + j + "";

                       tableLayoutPanel_AliadoDificil.Controls.Add(a);
                       tableLayoutPanel_EnemigoDificil.Controls.Add(b);
                    }
                }
                tableLayoutPanel_AliadoFacil.Visible = false;
                tableLayoutPanel_AliadoMedio.Visible = false;
                tableLayoutPanel_EnemigoFacil.Visible = false;
                tableLayoutPanel_EnemigoMedio.Visible = false;
            }
        }


        //Metodo para que escojer donde colocar el barco.
        private void buttonAction(Button boton,int tamano) {
            if (boton.Name == "0")
            {
                boton.Name = "1";
                boton.BackgroundImage = Image.FromFile(@"Nada.png");
            }
            else if (boton.Name == "1")
            {
                boton.Name = "0";
                boton.BackgroundImage = Image.FromFile(@"Agua.png");
            }
            
            this.Refresh();
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

        private void button_Listo(object sender, EventArgs e)
        {
            tableLayoutPanel_AliadoFacil.Enabled = false;
            tableLayoutPanel_AliadoMedio.Enabled = false;
            tableLayoutPanel_AliadoDificil.Enabled = false;
            button1.Visible = false;
        }
    }
}
