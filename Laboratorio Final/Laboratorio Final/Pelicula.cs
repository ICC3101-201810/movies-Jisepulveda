using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Final
{
    class Pelicula
    {
        public string nombre;
        public Persona director;
        public DateTime fecha_estreno;
        public string descripcion;
        public int presupuesto;
        public Estudio estudio;
        public List<Persona> actores;
        public Persona productor;

        public Pelicula(string pnombre, Persona pdirector, DateTime pfecha_estreno, string pdescripcion, int ppresupuesto, Estudio pestudio, List<Persona> pactores, Persona pproductor)
        {
            nombre = pnombre;
            pdirector = director;
            pfecha_estreno = fecha_estreno;
            pdescripcion = descripcion;
            ppresupuesto = presupuesto;
            pestudio = estudio;
            pactores = actores;
            pproductor = productor;
        }
    }
}
