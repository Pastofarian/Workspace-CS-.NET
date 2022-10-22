using System.ComponentModel.DataAnnotations;
using System.Collections;

using System;
using System.Collections.Generic;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var random = new Random();
            var SecretWord = new List<string> { "one", "two", "three", "four" };
            int index = random.Next(SecretWord.Count);
            Console.WriteLine(SecretWord[index]);
        }
    }
}