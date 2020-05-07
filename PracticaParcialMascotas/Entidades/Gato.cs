using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza)
            :base(nombre,raza)
        {            
        }
        protected override string Ficha()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.Append(string.Format($"{base.DatosCompletos()}"));
            return mensaje.ToString();
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return obj1.Raza == obj2.Raza && obj1.Nombre == obj2.Nombre;
        }
        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
    }
}
