using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        public enum TipoManada { Unica, Mixta }

        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        public TipoManada Tipo 
        { 
            set
            {
                tipo = value;
            }
        }
        static Grupo()
        {
            tipo = TipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre):this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, TipoManada tipo):this(nombre)
        {
            this.Tipo = tipo;
        }
        public static implicit operator string(Grupo e)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(string.Format($"**{e.nombre} {tipo}"));
            mensaje.AppendLine(string.Format("Integrantes:"));
            foreach (Mascota integrantes in e.manada)
            {
                mensaje.AppendLine(string.Format($"{integrantes.ToString()}"));
            }
            return mensaje.ToString();
        }
        public static bool operator ==(Grupo e, Mascota j)
        {
            foreach (Mascota item in e.manada)
            {
                if (item == j)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }
        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (e != j)
                e.manada.Add(j);
            return e;
        }
        public static Grupo operator -(Grupo e, Mascota j)
        {
            for (int i = 0; i < e.manada.Count; i++)
            {
                e.manada.RemoveAt(i);
            }
            return e;
        }
    }
}
