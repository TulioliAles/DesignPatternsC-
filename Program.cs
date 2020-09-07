using DesignPatterns._01_Creational._1._1_Abstract_Factory;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Creational Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Factory Method");
            Console.WriteLine("3 - Singleton");
            Console.WriteLine("------------------------");
            Console.WriteLine("Structural Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("4 - Adapter");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("------------------------");
            Console.WriteLine("Behavioral Patterns");
            Console.WriteLine("------------------------");
            Console.WriteLine("6 - Command");
            Console.WriteLine("7 - Strategy");
            Console.WriteLine("8 - Observer");
            Console.WriteLine("------------------------");

            var opcao = Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine("");

            switch(opcao.KeyChar)
            {
                case '1':
                    ExecucaoAbstractFactory.Executar();
                    break;
            }

        }
    }
}
