using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                if ((v1.ToLower() == "tesoura" && v2.ToLower() == "papel") ||
                    (v1.ToLower() == "papel" && v2.ToLower() == "pedra") ||
                    (v1.ToLower() == "pedra" && v2.ToLower() == "lagarto") ||
                    (v1.ToLower() == "lagarto" && v2.ToLower() == "spock") ||
                    (v1.ToLower() == "spock" && v2.ToLower() == "tesoura") ||
                    (v1.ToLower() == "tesoura" && v2.ToLower() == "lagarto") ||
                    (v1.ToLower() == "lagarto" && v2.ToLower() == "papel") ||
                    (v1.ToLower() == "papel" && v2.ToLower() == "spock") ||
                    (v1.ToLower() == "spock" && v2.ToLower() == "pedra") ||
                    (v1.ToLower() == "pedra" && v2.ToLower() == "tesoura"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);
                else if (v1.ToLower() == v2.ToLower())   //complete a solucao
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}
