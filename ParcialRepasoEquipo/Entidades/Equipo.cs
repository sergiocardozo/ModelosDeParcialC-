using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        public enum Deportes { Basquet, Futbol, HandBall, Rugby }
        
        private static Deportes deporte;
        private DirectorTecnico dt;
        private List<Jugador> jugadores;
        private string nombre;

        public Deportes Deporte 
        {
            set { deporte = value; }
        }

        static Equipo()
        {
            deporte = Deportes.Futbol;
        }
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, DirectorTecnico dt):this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }
        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte):this(nombre,dt)
        {            
            this.Deporte = deporte;
        }
        public static implicit operator string(Equipo e)
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine(string.Format($"** {e.nombre} **"));
            mensaje.AppendLine("Nomina Jugadores: ");
            foreach (Jugador item in e.jugadores)
            {
                mensaje.AppendLine(string.Format($"{item.ToString()}"));
            }
            mensaje.AppendLine($"Dirigido por : {e.dt.ToString()}");
            return mensaje.ToString();
        }
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador item in e.jugadores)
            {
                if (item == j)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (!(e is null) && e != j)
                e.jugadores.Add(j);
            return e;
        }
        public static Equipo operator -(Equipo e, Jugador j)
        {
            for (int i = 0; i < e.jugadores.Count; i++)
            {
                if (e.jugadores[i] == j)
                    e.jugadores.RemoveAt(i);
            }
            return e;
        }
    }
}
