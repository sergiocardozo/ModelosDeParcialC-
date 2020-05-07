using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short año;
        private Divisiones division;

        public string AñoDivision 
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(año);
                sb.Append(" ° ");
                sb.Append(division);
                return sb.ToString();
            }
        }
        public Alumno(string nombre, string apellido, string documento, short año, Divisiones division)
            :base(nombre,apellido,documento)
        {
            this.año = año;
            this.division = division;
        }
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.AñoDivision);
            sb.AppendLine(base.ExponerDatos());
            
            return sb.ToString();
        }
        protected override bool ValidarDocumentacion(string doc)
        {
            bool valida = false;
            if (doc.Length != 9)
                valida = false;
            else
            {
                int numero;
                bool esNumerico;

                for (int i = 0; i < doc.Length ; i++)
                {
                    esNumerico = int.TryParse(doc[i].ToString(), out numero);
                    if (!esNumerico)
                    {
                        if (doc[i] != '-')
                            valida = false;
                        break;
                    }
                    else
                    {
                        if(i != 2)
                        {
                            if (i != 7)
                                valida = false;
                            break;
                        }
                    }
                }
            }
            return valida;
        }
    }
}
