using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Registry registry = new Registry();
            Movie movie = (Movie)registry.CreateItem("Movie");
            movie.SetTitle("Creational Patterns in Java");
            Console.WriteLine(movie);
            Console.WriteLine(movie.GetRuntime());
            Console.WriteLine(movie.GetTitle());
            Console.WriteLine(movie.GetPrice());

            Console.WriteLine("*******************************************");

            Movie anotherMovie = (Movie)registry.CreateItem("Movie");
            anotherMovie.SetTitle("Gang of Four");
            Console.WriteLine(anotherMovie);
            Console.WriteLine(anotherMovie.GetRuntime());
            Console.WriteLine(anotherMovie.GetTitle());
            Console.WriteLine(anotherMovie.GetPrice());
        }
    }
}
