using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PrestamosPersonales
{
    public abstract class Prestamo
    {
        public enum TipoDePrestamo { Pesos, Dolares, Todos }
        public enum PeriodicidadDePago { Mensual, Bimestral, Trimestral }

        protected float monto;
        protected DateTime vencimiento;

        public float Monto
        {
            get { return this.monto; }
        }
        public DateTime Vencimiento
        {
            get { return vencimiento; }
            set 
            {
                if (value > this.vencimiento.Date)
                    this.vencimiento = value;
                else
                    this.vencimiento = DateTime.Now.Date;
            }
        }

        public Prestamo(float monto, DateTime vencimiento)
        {
            this.monto = monto;
            this.vencimiento = vencimiento;
        }
        public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"Monto a pagar: {this.Monto}"));
            sb.AppendLine(string.Format($"Vencimiento: {this.Vencimiento.ToString("MM/dd/yyyy")}"));
            return sb.ToString();
        } 
        public static int OrdenarPorFecha(Prestamo prestamo1, Prestamo prestamo2)
        {
            if (prestamo1.Vencimiento < prestamo2.Vencimiento)
                return 1;
            else if (prestamo1.Vencimiento > prestamo2.Vencimiento)
                return 0;
            else
                return -1;
        }


    }
}
