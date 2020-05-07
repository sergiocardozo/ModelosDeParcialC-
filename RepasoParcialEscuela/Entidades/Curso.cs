using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        private List<Alumno> alumnos;
        private short año;
        private Persona.Divisiones division;
        private Profesor profesor;

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
        private Curso()
        {
            this.alumnos = new List<Alumno>();
        }
        public Curso(short año, Profesor.Divisiones division, Profesor profesor): this()
        {
            this.año = año;
            this.division = division;
            this.profesor = profesor;
        }
        public static explicit operator string(Curso curso)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format($"{curso.AñoDivision}"));
            sb.AppendLine(string.Format($"{curso.profesor.ExponerDatos()}"));
            sb.AppendLine("Alumnos");
            foreach (Alumno item in curso.alumnos)
            {
                sb.Append(item.ExponerDatos().ToString());
            }
            return sb.ToString();
        }
        public static bool operator ==(Curso curso, Alumno alumno)
        {
            return curso.AñoDivision == curso.AñoDivision;
        }
        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso == alumno);
        }
        public static Curso operator +(Curso curso, Alumno alumno)
        {
            if (!(curso is null) && !(alumno is null))
                if (curso.AñoDivision == alumno.AñoDivision)
                    curso.alumnos.Add(alumno);
            return curso;
        }


    }
}
