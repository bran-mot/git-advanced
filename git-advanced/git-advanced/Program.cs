using System;

namespace gitadvanced
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cheer();

            Console.ReadLine();
        }

        public static void Cheer()
        {
            Console.WriteLine("C#");
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
