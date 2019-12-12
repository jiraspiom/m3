using System;

namespace M3paraLitros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Os valores devem ser digitado com virgula em metros:");
            Console.WriteLine("ex: 13 cm = 0,13;");
            Console.WriteLine("    1 metro = 1,00;)");
            Console.WriteLine("    1 metro e 42 cm = 1,42");


            Console.Write("Digite o raio: ");
            double raio = Double.Parse(Console.ReadLine());

            Console.Write("Digite a altura: ");
            double altura = Double.Parse(Console.ReadLine());

            MetroClindrico nome = new MetroClindrico(raio, altura);

            Console.WriteLine(nome);
        }

    }
}
