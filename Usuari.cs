using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Parallel
{
	public class Usuari
	{
		public string Name { get; set; }

		public string Surname { get; set; }

		public string gender { get; set; }
		
		public string company { get; set; }

		public string email { get; set; }

		public string country { get; set; }

		public string dni{ get; set; }

		public bool comprova_dni(string dni)
		{

			if (dni.Length == 9)
			{
				string numeros = dni.Substring(0, 8);

				if (dni[dni.Length - 1] == calcula_lletra(numeros)) return true;
				else return false;
			}
			else
			{
				return false;
			}
		}

		public bool comprova_mail(string email)
		{

			int posicio = email.IndexOf("@");

			if (posicio != 0 && posicio != email.Length) { return true; }
			else { return false; }
		}

		public bool comprova_nom(string Name)
		{

			if (String.IsNullOrEmpty(Name)) return false;
			else return true;

		}

		private char calcula_lletra(string str)
		{

			string CORRESPONDENCIA = "TRWAGMYFPDXBNJZSQVHLCKE";

			if (int.TryParse(str, out int result))
			{
				result = result % 23;
			}
			else throw new ArgumentException("El dni no te 8 digits");

			return CORRESPONDENCIA[result];
		}
	}
}