namespace Laboratorio_Final
{
    partial class Ventana_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventana_Principal));
            this.Buscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Peliculas = new System.Windows.Forms.Button();
            this.Actores = new System.Windows.Forms.Button();
            this.Directores = new System.Windows.Forms.Button();
            this.Productores = new System.Windows.Forms.Button();
            this.Estudios = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lista = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.ForeColor = System.Drawing.Color.LightGray;
            this.Buscar.Location = new System.Drawing.Point(45, 112);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(600, 20);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar...";
            this.Buscar.TextChanged += new System.EventHandler(this.Buscar_TextChanged);
            this.Buscar.Enter += new System.EventHandler(this.Buscar_Enter);
            this.Buscar.Leave += new System.EventHandler(this.Buscar_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Peliculas
            // 
            this.Peliculas.Location = new System.Drawing.Point(61, 163);
            this.Peliculas.Name = "Peliculas";
            this.Peliculas.Size = new System.Drawing.Size(100, 30);
            this.Peliculas.TabIndex = 2;
            this.Peliculas.Text = "Peliculas";
            this.Peliculas.UseVisualStyleBackColor = true;
            // 
            // Actores
            // 
            this.Actores.Location = new System.Drawing.Point(182, 163);
            this.Actores.Name = "Actores";
            this.Actores.Size = new System.Drawing.Size(100, 30);
            this.Actores.TabIndex = 3;
            this.Actores.Text = "Actores";
            this.Actores.UseVisualStyleBackColor = true;
            // 
            // Directores
            // 
            this.Directores.Location = new System.Drawing.Point(303, 163);
            this.Directores.Name = "Directores";
            this.Directores.Size = new System.Drawing.Size(100, 30);
            this.Directores.TabIndex = 4;
            this.Directores.Text = "Directores";
            this.Directores.UseVisualStyleBackColor = true;
            // 
            // Productores
            // 
            this.Productores.Location = new System.Drawing.Point(424, 163);
            this.Productores.Name = "Productores";
            this.Productores.Size = new System.Drawing.Size(100, 30);
            this.Productores.TabIndex = 5;
            this.Productores.Text = "Productores";
            this.Productores.UseVisualStyleBackColor = true;
            // 
            // Estudios
            // 
            this.Estudios.Location = new System.Drawing.Point(545, 163);
            this.Estudios.Name = "Estudios";
            this.Estudios.Size = new System.Drawing.Size(100, 30);
            this.Estudios.TabIndex = 6;
            this.Estudios.Text = "Estudios";
            this.Estudios.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Lista
            // 
            this.Lista.BackColor = System.Drawing.SystemColors.Window;
            this.Lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lista.ForeColor = System.Drawing.Color.Black;
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 19;
            this.Lista.Location = new System.Drawing.Point(45, 260);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(610, 230);
            this.Lista.TabIndex = 8;
            // 
            // Ventana_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Estudios);
            this.Controls.Add(this.Productores);
            this.Controls.Add(this.Directores);
            this.Controls.Add(this.Actores);
            this.Controls.Add(this.Peliculas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventana_Principal";
            this.Text = "Ventana_Principal";
            this.Load += new System.EventHandler(this.Ventana_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Peliculas;
        private System.Windows.Forms.Button Actores;
        private System.Windows.Forms.Button Directores;
        private System.Windows.Forms.Button Productores;
        private System.Windows.Forms.Button Estudios;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox Lista;
    }
}