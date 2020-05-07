using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public int Edad
        {
            get { return edad; }
            set
            {
                this.edad = value;
            }
        }
        public bool EsAlfa
        {
            get { return esAlfa; }
            set
            {
                this.esAlfa = value;
            }
        }

        public Perro(string nombre, string raza)
            : this(nombre, raza, 0, false)
        {
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa)
            : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        protected override string Ficha()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append(string.Format($"{base.DatosCompletos()}"));
            if (this.esAlfa == true)
                mensaje.Append(string.Format($" Alfa de la manada, Edad {this.edad}"));
            else
                mensaje.Append(string.Format($" ,edad {this.edad}"));
            return mensaje.ToString();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }
        public static bool operator ==(Perro perro1, Perro perro2)
        {
            return perro1.Nombre == perro2.Nombre && perro1.Raza == perro2.Raza && perro1.edad == perro2.edad;
        }
        public static bool operator !=(Perro perro1, Perro perro2)
        {
            return !(perro1 == perro2);
        }
    }
}
