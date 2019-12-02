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
        }

        public  void Count(string message, string message2)
        {
            Console.WriteLine(message + message2);
            Console.WriteLine("Greeting");

        }

        public void Future(string name)
        {
            Console.WriteLine(name);
            Console.WriteLine("Gemini");
        }
    }
}
