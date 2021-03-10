using System;

namespace ComunicacaoPiralandia
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            char[] arr = n.ToCharArray();
            //continue a solução
            Array.Reverse(arr);
            string v = new string(arr);
            Console.WriteLine(v + "\n");
        }
    }
}
