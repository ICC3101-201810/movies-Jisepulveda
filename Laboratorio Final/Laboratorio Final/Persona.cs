using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Final
{
    class Persona
    {
        public string nombre;
        public string apellido;
        public DateTime fecha_nacimiento;
        public string biografia;

        public Persona(string pnombre, string papellido, DateTime pfecha_nacimiento, string pbiografia)
        {
            pnombre = nombre;
            papellido = apellido;
            pfecha_nacimiento = fecha_nacimiento;
            pbiografia = biografia;
        }
    }
}
