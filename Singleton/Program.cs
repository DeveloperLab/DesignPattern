using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();

            if (singleton1 == singleton2)
                Console.WriteLine("Classes são iguais");
            else
                Console.WriteLine("Classes nãos são iguais");

            Console.WriteLine($"Guid create Singleton 1 {singleton1.Id}");
            Console.WriteLine($"Guid create Singleton 2 {singleton2.Id}");
        }
    }
}
