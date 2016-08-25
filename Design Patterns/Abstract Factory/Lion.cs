namespace Abstract_Factory
{
    internal class Lion : IMeatEater
    {
        public string Eat(IPlantEater plantEater)
        {
            return (this.GetType().Name + " eats " + plantEater.GetType().Name);
        }
    }
}