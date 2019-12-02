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

        public  void Count(string message)
        {
<<<<<<< HEAD
            Console.WriteLine("May!");
=======
            Console.WriteLine(message);
>>>>>>> 86c36906575381612f168ed79a17b54dd5882b4d
        }

        public void Future(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("Gemini");
        }
    }
}
