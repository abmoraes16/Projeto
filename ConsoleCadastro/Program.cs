using System;

namespace ConsoleCadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            //float f = 2.21f;
            //double d = 2.21;

            //Console.WriteLine(f);

            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(long.MaxValue);

            string coffee = FazerCafe("caramelo");

        }

        static string FazerCafe(string capsula){
            System.Console.WriteLine("Esquentar agua");
            System.Console.WriteLine("Colocar pó de magia (café)");
            System.Console.WriteLine("Colocar "+capsula);

            return "coffee";
        }
    }
}
