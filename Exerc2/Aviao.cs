using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc2
{
    class Aviao : Veiculo
    {
		private String Tipo = "AIR BUS";
		private String Uso = "Passeio";

		public String getTipo()
		{
			return Tipo;
		}
		public void setTipo(String tipo)
		{
			Tipo = tipo;
		}
		public String getUso()
		{
			return Uso;
		}
		public void setUso(String uso)
		{
			Uso = uso;
		}
	}
}
