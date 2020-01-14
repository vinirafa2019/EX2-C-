using System;

namespace Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro C = new Carro();
            C.Modelo = "Fit";
            C.Velocidade = 240;
            C.passageiros = 5;
            C.Combustivel = 150;
           Console.WriteLine("A Marca é: " + C.getMarca());
           Console.WriteLine("O carro tem " + C.getPortas() + " portas");
           Console.WriteLine("O ano do carro é: " + C.getAno());
           Console.WriteLine("A modelo é: " + C.getModelo());
           Console.WriteLine("A velocidade maxima é: " + C.getVelocidade() + " KM/H");
           Console.WriteLine("Qauntidade maxima de " + C.getpassageiros() + " passageiros");
           Console.WriteLine("Quantidade Maxima de Combustivel " + C.getCombustivel() + " Litros" + "\n");

           Aviao A = new Aviao ();
            A.Modelo = "Max 666";
            A.Velocidade = 840;
            A.passageiros = 120;
            A.Combustivel = 21000;
            Console.WriteLine("O tipo do aviao é: " + A.getTipo());
           Console.WriteLine("O modo de Us é: " + A.getUso());
           Console.WriteLine("A marca é: " + A.getModelo());
           Console.WriteLine("A velocidade maxima é: " + A.getVelocidade() + " KM/H");
           Console.WriteLine("Qauntidade maxima de " + A.getpassageiros() + " passageiros");
           Console.WriteLine("Quantidade Maxima de " + A.getCombustivel() + " Litros de combustivel");

        }
	}
}
