using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        public float Altura { get { return altura; } }
        public float Peso { get { return peso; } }
        public Posicion Posiciones { get { return posicion; } }

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion)
            :base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format($"{base.Mostrar()}, {this.peso}kg, {this.altura}cm, {this.posicion}"));
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            if (this.Edad <= 40 && ValidarEstadoFisico() == true)
                return true;
            else
                return false;
        }
        public bool ValidarEstadoFisico()
        {
            float imc;
            imc = this.peso / (this.altura * this.altura);
            if (imc >= 18.5 && imc <= 25)
                return true;
            else
                return false;
        }
    }
}
