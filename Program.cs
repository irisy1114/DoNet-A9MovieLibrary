using System;
using MovieLibrary.Services;

namespace MovieLibrary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orchestrator = new MediaOrchestrator();

            Console.Write("Enter the search string(enter 'my' to test): ");
            var searchString = Console.ReadLine().ToLower();
            var results = orchestrator.SearchAllMedia(searchString);

            Console.WriteLine("Your searching results are:");
            results.ForEach(Console.WriteLine);

        }
    }
}
