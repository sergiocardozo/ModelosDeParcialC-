using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime fechaIngreso;

        public int Antiguedad 
        { 
            get
            {
                TimeSpan timeSpan = new TimeSpan();
                timeSpan = DateTime.Now - this.fechaIngreso;
                int dias = (int)timeSpan.TotalDays;
                return dias;
            }
        }
        public Profesor(string nombre, string apellido, string documento)
            :this(nombre,apellido,documento,DateTime.Now)
        {
        }
        public Profesor(string nombre, string apellido, string documento, DateTime fechaIngreso)
            :base(nombre,apellido,documento)
        {
            this.fechaIngreso = fechaIngreso;
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Profesor : ");
            sb.Append(string.Format($"{base.ExponerDatos()}"));
            sb.Append(string.Format($"Antiguedad {this.Antiguedad.ToString()} dias"));
            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            if (!(doc.Length > 8))
                return true;
            return false;
        }
    }
}
