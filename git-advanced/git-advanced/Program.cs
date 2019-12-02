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

        public static void Cheer(int numberOfMembers)
        {
            Console.WriteLine($"We are React team! With {numberOfMembers} members.");
        }

        public  void Count()
        {
            Console.WriteLine("Martin!");
        }

        public void Future(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("Gemini");
        }
    }
}
