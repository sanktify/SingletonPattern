using System;
namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private int counter = 0;
        private static readonly Object obj = new object();
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter: " + counter.ToString());
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (obj)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        };
                    }
                }
                return instance;
            }
        }

        public void DisplayValues(string input)
        {
            Console.WriteLine(input); 
        }
    }
}