﻿using System;
namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static Singleton instance;
        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                };
                return instance;
            }
        }

        public void DisplayValues(string input)
        {
            Console.WriteLine(input); 
        }
    }
}