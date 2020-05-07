using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
		private string nombre;
		private string raza;
		/// <summary>
		/// Propiedad de nombre solo lectura
		/// </summary>
		public string Nombre
		{
			get { return nombre; }
			
		}
		/// <summary>
		/// Propiedad Raza solo lectura
		/// </summary>
		public string Raza
		{
			get { return raza; }			
		}
		/// <summary>
		/// Constructor que instancia el nombre y la raza de la mascota
		/// </summary>
		/// <param name="nombre"></param>
		/// <param name="raza"></param>
		public Mascota(string nombre, string raza)
		{
			this.nombre = nombre;
			this.raza = raza;
		}
		/// <summary>
		/// Metodo que retornara los datos de la mascota
		/// </summary>
		/// <returns></returns>
		protected virtual string DatosCompletos()
		{
			StringBuilder mensaje = new StringBuilder();
			mensaje.Append(string.Format($"{this.Nombre} {this.Raza}"));
			return mensaje.ToString();
		}
		/// <summary>
		/// Metodo abstracto que no recibe implementacion
		/// </summary>
		/// <returns></returns>
		protected abstract string Ficha();

	}
}
