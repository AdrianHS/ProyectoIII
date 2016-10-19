namespace Proyecto_III___v._0
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox_Dificultad = new System.Windows.Forms.ComboBox();
            this.label_Jugador = new System.Windows.Forms.Label();
            this.button_Jugar = new System.Windows.Forms.Button();
            this.label_Dificultad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.prueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Dificultad
            // 
            this.comboBox_Dificultad.FormattingEnabled = true;
            this.comboBox_Dificultad.Items.AddRange(new object[] {
            "Facil",
            "Medio",
            "Dificil"});
            this.comboBox_Dificultad.Location = new System.Drawing.Point(82, 132);
            this.comboBox_Dificultad.Name = "comboBox_Dificultad";
            this.comboBox_Dificultad.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Dificultad.TabIndex = 0;
            this.comboBox_Dificultad.Text = "Facil";
            this.comboBox_Dificultad.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dificultad_SelectedIndexChanged);
            // 
            // label_Jugador
            // 
            this.label_Jugador.AutoSize = true;
            this.label_Jugador.Location = new System.Drawing.Point(117, 72);
            this.label_Jugador.Name = "label_Jugador";
            this.label_Jugador.Size = new System.Drawing.Size(55, 13);
            this.label_Jugador.TabIndex = 1;
            this.label_Jugador.Text = "Jugador #";
            this.label_Jugador.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_Jugar
            // 
            this.button_Jugar.Location = new System.Drawing.Point(101, 194);
            this.button_Jugar.Name = "button_Jugar";
            this.button_Jugar.Size = new System.Drawing.Size(75, 23);
            this.button_Jugar.TabIndex = 2;
            this.button_Jugar.Text = "Jugar";
            this.button_Jugar.UseVisualStyleBackColor = true;
            this.button_Jugar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Dificultad
            // 
            this.label_Dificultad.Location = new System.Drawing.Point(56, 113);
            this.label_Dificultad.Name = "label_Dificultad";
            this.label_Dificultad.Size = new System.Drawing.Size(187, 16);
            this.label_Dificultad.TabIndex = 0;
            this.label_Dificultad.Text = "Dificultad:";
            this.label_Dificultad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Batalla Naval";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // prueba
            // 
            this.prueba.AutoSize = true;
            this.prueba.Location = new System.Drawing.Point(131, 239);
            this.prueba.Name = "prueba";
            this.prueba.Size = new System.Drawing.Size(35, 13);
            this.prueba.TabIndex = 4;
            this.prueba.Text = "label1";
            this.prueba.Click += new System.EventHandler(this.prueba_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 261);
            this.Controls.Add(this.prueba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Dificultad);
            this.Controls.Add(this.button_Jugar);
            this.Controls.Add(this.label_Jugador);
            this.Controls.Add(this.comboBox_Dificultad);
            this.Name = "MenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Dificultad;
        private System.Windows.Forms.Label label_Jugador;
        private System.Windows.Forms.Button button_Jugar;
        private System.Windows.Forms.Label label_Dificultad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label prueba;
    }
}

