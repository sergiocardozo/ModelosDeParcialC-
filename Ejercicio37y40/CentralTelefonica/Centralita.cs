using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        public float GananciasPorLocal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float acumulado = 0;
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Local)
                        acumulado += ((Local)llamada).CostoLlamada;
                }
                if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
                {
                    if (llamada is Provincial)
                        acumulado += ((Provincial)llamada).CostoLlamada;
                }
            }
            return acumulado;
        }
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Razon Social {this.razonSocial} GananciaTotal {this.GananciasPorTotal:C2}" +
                $" GananciaLocal {this.GananciasPorLocal:C2} GananciaProvincial {this.GananciasPorProvincial:C2}"));
            sb.AppendLine("");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                    sb.Append(((Local)llamada).ToString());
                else if (llamada is Provincial)
                    sb.Append(((Provincial)llamada).ToString());
            }            
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        public static bool operator ==(Centralita c,Llamada llamada)
        {
            return c.listaDeLlamadas.Contains(llamada);
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
                c.listaDeLlamadas.Add(llamada);
            return c;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
