using System;

namespace gitadvanced
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cheer(4);

            Console.ReadLine();
        }

        public static void Future()
        {
            Console.WriteLine("Chinese Sign"); 
        }

        public static void Cheer(int numberOfMembers)
        {
            Console.WriteLine("C#");
            Console.WriteLine($"We are React team! With {numberOfMembers} members.");
        }

        public  void Count(string message)
        {
            Console.WriteLine("May!");
            Console.WriteLine(message);
        }

        public void Future(string name, string surname)
        {
            Console.WriteLine(name, surname);
            Console.WriteLine("Gemini");
        }
    }
}
