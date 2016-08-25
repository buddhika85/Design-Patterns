namespace Abstract_Factory
{
    internal class Wolf : IMeatEater
    {
        public string Eat(IPlantEater plantEater)
        {
            // wolf eats bison
            return (this.GetType().Name + " eats " + plantEater.GetType().Name);
        }
    }
}