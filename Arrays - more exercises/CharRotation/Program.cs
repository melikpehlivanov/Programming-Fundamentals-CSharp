﻿namespace CharRotation
{
    using System;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var array = Console.ReadLine().ToCharArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write((char)(array[i] - (char)numbers[i]));
                }
                else
                {
                    Console.Write((char)(array[i] + (char)numbers[i]));
                }
            }

            Console.WriteLine();
        }
    }
}

