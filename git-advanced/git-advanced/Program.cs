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
<<<<<<< HEAD
            Console.WriteLine("C#");
=======
            Console.WriteLine($"We are React team! With {numberOfMembers} members.");
>>>>>>> 711ce507812621b45a7696990b8d4bd366105bb4
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
