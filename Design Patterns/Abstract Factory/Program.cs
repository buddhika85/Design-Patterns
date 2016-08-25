using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalWorld_Client world = null;
            IContinentFactory continent = null;
            string result = null;

            continent = new AmericaFactory();
            world = new AnimalWorld_Client(continent);
            result = world.RunFoodChain();
            Console.WriteLine(result);                      // Wolf eats Bison

            continent = new AfricaFactory();
            world = new AnimalWorld_Client(continent);
            result = world.RunFoodChain();
            Console.WriteLine(result);                      // Lion eats Wildebeest

            Console.ReadLine();
        }
    }
}
