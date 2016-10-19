namespace Proyecto_III___v._0
{
    partial class Inicio
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
            this.button_Crear = new System.Windows.Forms.Button();
            this.button_Unirse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Crear
            // 
            this.button_Crear.Location = new System.Drawing.Point(87, 98);
            this.button_Crear.Name = "button_Crear";
            this.button_Crear.Size = new System.Drawing.Size(105, 23);
            this.button_Crear.TabIndex = 0;
            this.button_Crear.Text = "Crear Partida";
            this.button_Crear.UseVisualStyleBackColor = true;
            this.button_Crear.Click += new System.EventHandler(this.button_Crear_Click);
            // 
            // button_Unirse
            // 
            this.button_Unirse.Location = new System.Drawing.Point(87, 163);
            this.button_Unirse.Name = "button_Unirse";
            this.button_Unirse.Size = new System.Drawing.Size(105, 23);
            this.button_Unirse.TabIndex = 1;
            this.button_Unirse.Text = "Unirse a Partida";
            this.button_Unirse.UseVisualStyleBackColor = true;
            this.button_Unirse.Click += new System.EventHandler(this.button_Unirse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Batalla Naval";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Unirse);
            this.Controls.Add(this.button_Crear);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Crear;
        private System.Windows.Forms.Button button_Unirse;
        private System.Windows.Forms.Label label3;
    }
}