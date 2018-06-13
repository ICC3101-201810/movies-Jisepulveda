using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Final
{
    class Estudio
    {
        public string nombre;
        public string direccion;
        public DateTime fecha_apertura;

        public Estudio(string enombre, string edireccion, DateTime efecha_apertura)
        {
            enombre = nombre;
            edireccion = direccion;
            efecha_apertura = fecha_apertura;
        }
    }
}
