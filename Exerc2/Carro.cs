using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc2
{
    class Carro : Veiculo
    {
        private string Marca= "Honda";
        private int Portas = 4;
        private string Ano= "2019";


        
        public string getMarca()
        {
            return Marca;
        }
        public void setMarca(string Marca)
        {
            this.Marca = Marca;
        }

        public int getPortas()
        {
            return Portas;
        }
        public void setPortas(int Portas)
        {
            this.Portas = Portas;
        }
        public string getAno()
        {
            return Ano;
        }
        public void setAno(string Ano)
        {
            this.Ano = Ano;
        }
    }
}
