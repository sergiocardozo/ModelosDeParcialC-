
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrestamosPersonales;

namespace EntidadFinanciera
{
    public class Financiera
    {
        private List<Prestamo> listaDePrestamos;
        private string razonSocial;

        public float InteresesEnDolares
        {
            get { return this.CalcularInteresGanado(Prestamo.TipoDePrestamo.Dolares); }
        }
        public float InteresesEnPesos
        {
            get { return this.CalcularInteresGanado(Prestamo.TipoDePrestamo.Pesos); }
        }
        public float InteresesTotales
        {
            get { return this.CalcularInteresGanado(Prestamo.TipoDePrestamo.Todos); }
        }
        public List<Prestamo> ListaDePrestamos
        {
            get { return this.listaDePrestamos; }
        }
        public string RazonSocial
        {
            get { return this.razonSocial; }
        }
        private Financiera()
        {
            this.listaDePrestamos = new List<Prestamo>();
        }
        public Financiera(string razonSocial) : this()
        {
            this.razonSocial = razonSocial;
        }
        private float CalcularInteresGanado(Prestamo.TipoDePrestamo tipoDePrestamo)
        {
            float retorno = 0;
            float retornoDolar = 0;
            float retornoPeso = 0;
            PrestamoDolar prestamoDolar;
            PrestamoPesos prestamosPesos;

            foreach (Prestamo item in this.listaDePrestamos)
            {
                if (item is PrestamoDolar)
                {
                    prestamoDolar = (PrestamoDolar)item;
                    retornoDolar += prestamoDolar.Interes;
                }
                else
                {
                    prestamosPesos = (PrestamoPesos)item;
                    retornoPeso += prestamosPesos.Interes;
                }
            }
            switch (tipoDePrestamo)
            {
                case Prestamo.TipoDePrestamo.Pesos:
                    retorno = retornoPeso;
                    break;
                case Prestamo.TipoDePrestamo.Dolares:
                    retorno = retornoDolar;
                    break;
                case Prestamo.TipoDePrestamo.Todos:
                    retorno = retornoDolar + retornoPeso;
                    break;
            }
            return retorno;
        }
        public static string Mostrar(Financiera financiera)
        {
            return (string)financiera;
        }
        public void OrdenarPrestamos()
        {
            this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
        }
        public static explicit operator string(Financiera financiera)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Prestamo item in financiera.listaDePrestamos)
            {
                sb.Append(string.Format($"{item.Mostrar()}"));
                sb.AppendLine("");
            }
            return sb.ToString();
        }
        public static bool operator ==(Financiera financiera, Prestamo prestamo)
        {
            if (!(financiera is null) && !(prestamo is null))
            {
                foreach (Prestamo item in financiera.listaDePrestamos)
                {
                    if (object.Equals(item, prestamo))
                        return true;
                }
            }
            return false;
        }
        public static bool operator !=(Financiera financiera, Prestamo prestamo)
        {
            return !(financiera == prestamo);
        }
        public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
        {
            if (!(financiera is null) && !(prestamoNuevo is null))
            {
                if (financiera == prestamoNuevo)
                    return financiera;
                financiera.listaDePrestamos.Add(prestamoNuevo);
            }
            return financiera;
        }
    }
}
