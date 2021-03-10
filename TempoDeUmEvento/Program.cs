using System;

namespace TempoDeUmEvento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;
            int dia, hora, minuto, segundo;
            //continue escrevendo a solucao

            string[] dadosInicio = Console.ReadLine().Split();
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split();
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[4]);

            string[] dadosTermino = Console.ReadLine().Split();
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split();
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[2]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[4]);

            dia = diaTermino - diaInicio;
            hora = horaMomentoTermino - horaMomentoInicio;
            minuto = minutoMomentoTermino - minutoMomentoInicio;
            segundo = segundoMomentoTerminio - segundoMomentoInicio;

            if (segundo < 0)
            {
                segundo += 60;
                minuto--;
            }

            if (minuto < 0)
            {
                minuto += 60;
                hora--;
            }

            if (hora < 0)
            {
                hora += 24;
                dia--;
            }

            Console.WriteLine("{0} dia(s)", dia);
            Console.WriteLine("{0} horas(s)", hora);
            Console.WriteLine("{0} minuto(s)", minuto);
            Console.WriteLine("{0} segundo(s)", segundo);
        }
    }
}
