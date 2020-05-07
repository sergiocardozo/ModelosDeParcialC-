using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Roberto", "Carlos", 6, false);
            Jugador jugador2 = new Jugador("Lionel", "Messi", 10, true);
            Jugador jugador3 = new Jugador("Cristiano", "Ronaldo", 7, false);
            Jugador jugador4 = new Jugador("Juan Roman", "Riquelme", 10, true);

           

            Equipo equipo = new Equipo("Boca Juniors", new DirectorTecnico("Julio Cesar", "Falcioni"), Equipo.Deportes.Futbol);
            Equipo equipo1 = new Equipo("River Plate", new DirectorTecnico("Carlos", "Bianchi"), Equipo.Deportes.Basquet);
            Equipo equipo2 = new Equipo("Racing Club", new DirectorTecnico("Bichi", "Borghi"), Equipo.Deportes.HandBall);
            Equipo equipo3 = new Equipo("Independiente", new DirectorTecnico("Guillermo", "Schellotto"), Equipo.Deportes.Rugby);

            equipo1 += jugador;
            equipo1 += jugador2;
            equipo1 += jugador3;
            equipo1 = equipo + jugador4;
            ;
            Console.WriteLine(equipo1);

            Console.WriteLine();
            equipo2 += jugador;
            equipo2 -= jugador2;
            Console.WriteLine(equipo2);

            equipo3 += jugador4;

            Console.WriteLine(equipo3);


            equipo -= jugador3;
            Console.WriteLine(equipo);
            Console.ReadKey();
        }
    }
}
