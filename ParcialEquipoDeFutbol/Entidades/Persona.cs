using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public enum Posicion { Arquero, Defensor, Central, Delantero}


        private string apellido;
        private int edad;
        private int dni;
        private string nombre;

        public string Apellido { get { return apellido; } }
        public int Edad { get { return edad; } }
        public int Dni { get { return dni; } }
        public string Nombre { get { return nombre; } }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($"{this.nombre} {this.apellido}, {this.edad} años, DNI: {this.dni}"));
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
