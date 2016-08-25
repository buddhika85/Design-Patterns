namespace Abstract_Factory
{
    class AmericaFactory : IContinentFactory
    {
        public IMeatEater CreateMeatEater()
        {
            return new Wolf();
        }

        public IPlantEater CreatePlantEater()
        {
            return new Bison();
        }
    }
}
