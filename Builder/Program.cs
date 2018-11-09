using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SandwichDirector sandwichDirector = new SandwichDirector(new MySandwichBuilder());
            sandwichDirector.buildSandwich();
            Sandwich sandwich1 = sandwichDirector.getSandwhich();
            sandwich1.display();

            SandwichDirector sandwichDirector2 = new SandwichDirector(new ClubSandwichBuilder());
            sandwichDirector2.buildSandwich();
            Sandwich sandwich2 = sandwichDirector2.getSandwhich();
            sandwich2.display();
        }
    }
}
