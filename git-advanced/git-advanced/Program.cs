using System;

namespace gitadvanced
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cheer(4,"Lukas");

            Console.ReadLine();
        }

        public static void Future()
        {
            Console.WriteLine("Chinese Sign"); 
        }

        public static void Cheer(int numberOfMembers, string name)
        {
            Console.WriteLine("C#");

            Console.WriteLine(name);
            Console.WriteLine("C#");
            Console.WriteLine($"We are React team! With {numberOfMembers} members.");
        }

        public  void Count(string message, string message2)
        {
            Console.WriteLine(message + message2);

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
