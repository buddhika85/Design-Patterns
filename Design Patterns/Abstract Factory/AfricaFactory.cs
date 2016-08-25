namespace Abstract_Factory
{
    class AfricaFactory : IContinentFactory
    {
        public IMeatEater CreateMeatEater()
        {
            return new Lion();
        }

        public IPlantEater CreatePlantEater()
        {
            return new WildeBeest();
        }
    }
}
