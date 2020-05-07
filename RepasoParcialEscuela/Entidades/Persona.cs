using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        public enum Divisiones { A, B, C, D, E }
        private string apellido;
        private string nombre;
        private string documento;

        public string Apellido
        {
            get { return apellido; }
        }
        public string Nombre
        {
            get { return nombre; }
        }
        public string Documento
        {
            get { return documento; }
            set
            {
                if (ValidarDocumentacion(value))
                    this.documento = value;
            }
        }
        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.documento = documento;
        }
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($" {this.nombre}"));
            sb.Append(string.Format($" {this.apellido}"));
            sb.Append(string.Format($" Documento: {this.documento} "));
            return sb.ToString();
        }
        protected abstract bool ValidarDocumentacion(string doc);
    }
}
