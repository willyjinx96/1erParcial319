/*
 * Created by SharpDevelop.
 * User: willy
 * Date: 17/5/2022
 * Time: 15:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio_2
{
	public class Numero
	{
		private double _Numero1;
		private double _Numero2;
 
		public double Numero1 {
			get { return _Numero1; }
			set { _Numero1 = value; }
		}
 
		public double Numero2 {
			get { return _Numero2; }
			set { _Numero2 = value; }
		}
 
		public double Sumar()
		{
			return Numero1 + Numero2;
		}
		public double Restar()
		{
			return Numero1 - Numero2;
		}
		public double Multiplicar()
		{
			return Numero1 * Numero2;
		}
		public object Dividir()
		{
			if (Numero2 != 0) {
				return Numero1 / Numero2;
			} else {
				return "No se puede dividir entre 0";
			}
		}
	}
}