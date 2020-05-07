
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public class PrestamoPesos : Prestamo
    {
        private float porcentajeInteres;

        public float Interes 
        { 
            get { return this.CalcularInteres(); }
        }
        public PrestamoPesos(float monto,DateTime vencimiento,float interes) 
            :base(monto,vencimiento)
        {
            this.porcentajeInteres = interes;
        }
        public PrestamoPesos(Prestamo prestamo, float porcentajeinteres)
            :this(prestamo.Monto,prestamo.Vencimiento,porcentajeinteres)
        {
        }
        private float CalcularInteres()
        {
            float retorno = 0;
            retorno = (this.porcentajeInteres * this.Monto) / 100;
            retorno += this.Monto;
            return retorno;
        }
        public override void ExtenderPlazo(DateTime nuevoVencimiento)
        {
            double dias;
            dias = nuevoVencimiento.Subtract(this.Vencimiento).TotalDays;
            dias = (int)dias * 0.25;
            this.porcentajeInteres += (float)dias;
            this.Vencimiento = nuevoVencimiento;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.Mostrar()}"));            
            sb.AppendLine(string.Format($"Intereses: {this.Interes}"));
            return sb.ToString();
        }

    }
}
