using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc2
{
    class Veiculo
    {
        public string Modelo;
        public int passageiros;
        public int Combustivel;
        public int Velocidade;

        public String getModelo()
        {
            return Modelo;
        }
        public void setModelo(String Modelo)
        {
            this.Modelo = Modelo;
        }
        public int getVelocidade()
        {
            return Velocidade;
        }
        public void setVelocidade(int Velocidade)
        {
            this.Velocidade = Velocidade;
        }
        public int getpassageiros()
        {
            return passageiros;
        }
        public void setpassageiros(int passageiros)
        {
            this.passageiros = passageiros;
        }
        public int getCombustivel()
        {
            return Combustivel;
        }
        public void setCombustivel(int Combustivel)
        {
            this.Combustivel = Combustivel;
        }
    }
}
