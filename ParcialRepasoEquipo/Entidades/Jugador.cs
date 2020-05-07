using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private bool esCapitan;
        private int numero;

        public bool EsCapitan
        {
            get { return this.esCapitan; }
            set { this.esCapitan = value; }
        }
        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }
        public Jugador(string nombre, string apellido) : this(nombre, apellido, 0, false)
        {

        }
        public Jugador(string nombre, string apellido, int numero, bool capitan) : base(nombre, apellido)
        {
            this.numero = numero;
            this.esCapitan = capitan;
        }
        protected override string FichaTecnica()
        {
            StringBuilder mensaje = new StringBuilder();

            if (this.esCapitan == true)
                mensaje.Append(string.Format($"{base.NombreCompleto()} Capitan del equipo, camiseta numero: {this.numero}"));
            else
                mensaje.Append(string.Format($"{base.NombreCompleto()} camiseta numero: {this.numero}"));
            return mensaje.ToString();
        }
        public override string ToString()
        {
            return this.FichaTecnica();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public static explicit operator int(Jugador jugador)
        {
            return jugador.numero;
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
