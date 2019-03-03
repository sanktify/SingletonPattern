using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.Instance;
            obj.DisplayValues("this is from Program class");
        }
    }
}
