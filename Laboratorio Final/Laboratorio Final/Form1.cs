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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void tiempo_Tick(object sender, EventArgs e)
        {
            Ventana_Principal ventana = new Ventana_Principal();
            ventana.Show();
            this.Hide();
            tiempo.Stop();
        }

        Timer tiempo = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            tiempo.Interval = 5000;
            tiempo.Tick += new EventHandler(tiempo_Tick);
            tiempo.Start();

        }
    }
}
