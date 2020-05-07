using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())//si el director tecnigo es valido le asigna un valor
                    this.directorTecnico = value;
            }
        }
        public string Nombre { get { return nombre; } }

        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public static bool ValidarEquipo(Equipo equipo)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;

            foreach (Jugador item in equipo.jugadores)
            {
                switch (item.Posiciones)
                {
                    case Persona.Posicion.Arquero:
                        arquero++;
                        break;
                    case Persona.Posicion.Defensor:
                        defensor++;
                        break;
                    case Persona.Posicion.Central:
                        central++;
                        break;
                    case Persona.Posicion.Delantero:
                        delantero++;
                        break;
                    default:
                        break;
                }
            }
            if (!(equipo.directorTecnico is null))
            {
                if (Equipo.cantidadMaximaJugadores == equipo.jugadores.Count())
                {
                    if (arquero == 1 && delantero > 0 && central > 0 && delantero > 0)
                        return true;
                }
            }
            return false;
        }
        public static explicit operator string(Equipo equipo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Nombre del equipo {equipo.nombre}"));
            sb.AppendLine("");
            if (equipo.directorTecnico is null)
                sb.AppendLine(string.Format($" Sin director Tecnico"));
            else
                sb.AppendLine(string.Format($"{equipo.directorTecnico.Mostrar()}"));

            foreach (Jugador item in equipo.jugadores)
            {
                sb.Append(string.Format($"{item.Mostrar()}"));
            }
            return sb.ToString();
        }
        public static bool operator ==(Equipo equipo, Jugador jugador)
        {
            foreach (Jugador item in equipo.jugadores)
            {
                if (object.Equals(item, jugador))
                    return true;
            }
            return false;
        }
        public static bool operator !=(Equipo equipo, Jugador jugador)
        {
            return !(equipo == jugador);
        }
        public static Equipo operator +(Equipo equipo, Jugador jugador)
        {
            if (!(equipo is null) && !(jugador is null))
            {
                if (!(equipo == jugador))
                {
                    if (Equipo.cantidadMaximaJugadores > equipo.jugadores.Count && jugador.ValidarAptitud())
                        equipo.jugadores.Add(jugador);
                }
            }
            return equipo;
        }
    }
}
