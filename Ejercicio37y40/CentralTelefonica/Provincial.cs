using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Provincial(Franja miFranja, Llamada llamada)
            :this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            :base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.Mostrar()} {this.CostoLlamada:C2} {this.franjaHoraria}"));
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            float retorno = 0;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = this.duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    retorno = this.duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    retorno = this.duracion * (float)0.66;
                    break;                
            }
            return retorno;
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;
            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        public enum Franja { Franja_1, Franja_2, Franja_3 }
    }
}
