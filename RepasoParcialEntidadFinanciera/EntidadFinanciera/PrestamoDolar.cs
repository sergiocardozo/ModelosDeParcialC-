
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoDolar : Prestamo
    {
        private PeriodicidadDePago periodicidad;

        public float Interes 
        {
            get { return this.CalcularInteres(); }
        }
        public PeriodicidadDePago Periodicidad 
        {
            get { return this.periodicidad; }
        }
        public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePago periodicidad)
            : base(monto,vencimiento)
        {
            this.periodicidad = periodicidad;
        }
        public PrestamoDolar(Prestamo prestamo, PeriodicidadDePago periodicidad)
            :this(prestamo.Monto,prestamo.Vencimiento,periodicidad)
        {
        }
        private float CalcularInteres()
        {
            float retorno = 0;
            switch (periodicidad)
            {
                case PeriodicidadDePago.Mensual:
                    retorno = (25 * this.Monto) / 100;
                    retorno += this.Monto;
                    break;
                case PeriodicidadDePago.Bimestral:
                    retorno = (35 * this.Monto) / 100;
                    retorno += this.Monto;
                    break;
                case PeriodicidadDePago.Trimestral:
                    retorno = (40 * this.Monto) / 100;
                    retorno += this.Monto;
                    break;
            }
            return retorno;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double dias;
            dias = nuevoVencimiento.Subtract(this.Vencimiento).TotalDays;
            dias = (int)dias * 2.5;
            this.monto += (float)dias;
            this.Vencimiento = nuevoVencimiento;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.Mostrar()}"));
            sb.AppendLine(string.Format($"Periodicidad de pago: {this.Periodicidad}"));
            sb.AppendLine(string.Format($"Intereses: {this.Interes}"));
            return sb.ToString();
        }
    }
}
