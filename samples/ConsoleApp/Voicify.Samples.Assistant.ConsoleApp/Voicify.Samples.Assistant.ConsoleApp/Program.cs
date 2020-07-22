using System;

namespace Voicify.Samples.Assistant.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Voicify Assistant Sample App!");
            Console.WriteLine("Enter your \"Custom Assistant\" fulfillment URL for the app you want to use. You can find it in your app settings in the Voicify CMS");
            var url = Console.ReadLine();


        }
    }
}
