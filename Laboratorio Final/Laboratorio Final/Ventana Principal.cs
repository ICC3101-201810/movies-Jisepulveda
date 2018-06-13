using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Final
{
    public partial class Ventana_Principal : Form
    {
        public Ventana_Principal()
        {
            InitializeComponent();
            Lista.Visible = false;
        }

        private void Buscar_Enter(object sender, EventArgs e)
        {
            if (Buscar.Text=="Buscar...")
            {
                Buscar.Text = "";
                Buscar.ForeColor = Color.Black;
            }
        }

        private void Buscar_Leave(object sender, EventArgs e)
        {
            if (Buscar.Text=="")
            {
                Buscar.Text = "Buscar...";
                Buscar.ForeColor = Color.LightGray;
            }
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            if (Buscar.Text.Length >= 3 )
            {
                Buscar.ForeColor = Color.Black;
                this.Height = 500;
                Lista.Visible = true;

                BD basedatos = new BD();

                Lista.Items.Clear();

                foreach (Persona persona in basedatos.Filtroper(Buscar.Text))
                {
                    Lista.Items.Add(persona.nombre + " - " + persona.apellido);
                }

                foreach (Pelicula pelicula in basedatos.Filtropel(Buscar.Text))
                {
                    Lista.Items.Add(pelicula.nombre + " - " + pelicula.director);
                }

                foreach (Estudio estudio in basedatos.Filtroest(Buscar.Text))
                {
                    Lista.Items.Add(estudio.nombre + " - " + estudio.direccion);
                }


            }

            else
            {
                Buscar.ForeColor = Color.Black;
                this.Height = 250;
                Lista.Visible = false;
            }
            
        }

        private void Ventana_Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
