using Builder.ConcreteBuilders;
using Builder.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // different builders
            MotorCycleBuilder motorCycleBuilder = new MotorCycleBuilder();
            CarBuilder carBuilder = new CarBuilder();
            ScooterBuilder scooterBuilder = new ScooterBuilder();
            
            // create a director object
            Shop shop = new Shop();
            shop.Construct(motorCycleBuilder);
            motorCycleBuilder.Vehicle.Show();

            shop.Construct(carBuilder);
            carBuilder.Vehicle.Show();

            shop.Construct(scooterBuilder);
            scooterBuilder.Vehicle.Show();

            Console.ReadKey();
        }
    }
}
