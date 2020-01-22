using System;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            // Max heart rate is equal 220 - age
            age = 46;
            height = 61;
            int maxheartrate = 220 - age;
            

            //Console should write: I am ### years old, my max heart rate is ## and I am ### inches tall.

            Console.WriteLine("I am " + age + " years old, " + " my max heart rate is " + maxheartrate + " and I am " + height + " inches tall");

        }
    }
}
