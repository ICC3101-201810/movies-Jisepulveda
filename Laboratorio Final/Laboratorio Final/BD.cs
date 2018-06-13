using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Laboratorio_Final
{
    class BD
    {
        List<Persona> personas = new List<Persona>();
        List<Pelicula> peliculas = new List<Pelicula>();
        List<Estudio> estudios = new List<Estudio>();

        Persona persona = new Persona("Brad", "Pitt", Convert.ToDateTime("18/12/1963"), "William Bradley Pitt, ​ conocido como Brad Pitt, es un actor y productor de cine estadounidense");

        public List<Persona> Filtroper(string texto)
        {
            List<Persona> Filtradoper = new List<Persona>();

            foreach (Persona persona in personas)
            {
                if (persona.nombre.Contains(texto) || persona.apellido.Contains(texto))
                {
                    Filtradoper.Add(persona);
                }
            }
            return Filtradoper;
        }

        public List<Pelicula> Filtropel(string texto)
        {
            List<Pelicula> Filtradopel = new List<Pelicula>();
            foreach (Pelicula pelicula in peliculas)
            {
                Console.WriteLine("entro");
                if (pelicula.nombre.Contains(texto) || pelicula.descripcion.Contains(texto))
                {
                    Filtradopel.Add(pelicula);
                }
            }
            return Filtradopel;
        }
        public List<Estudio> Filtroest(string texto)
        { 
            List<Estudio> Filtradoest = new List<Estudio>();
            foreach (Estudio estudio in estudios)
            {
                if (estudio.nombre.Contains(texto) || estudio.direccion.Contains(texto))
                {
                    Filtradoest.Add(estudio);
                }
            }
            return Filtradoest;
        }
    }
}
