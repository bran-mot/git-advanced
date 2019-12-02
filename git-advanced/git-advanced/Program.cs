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
            Console.WriteLine($"We are React team! With {numberOfMembers} members.");
        }

        public  void Count(string message)
        {
            Console.WriteLine(message);
        }

        public void Future(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("Gemini");
        }
    }
}
