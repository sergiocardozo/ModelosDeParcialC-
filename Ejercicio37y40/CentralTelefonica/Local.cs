﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

        public override float CostoLlamada { get { return this.CalcularCosto(); } }

        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder("");
            sb.Append(string.Format($"{base.Mostrar()} {this.CostoLlamada:C}"));
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public override bool Equals(object obj)
        {
            return (obj is Local) ? true : false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
