namespace Abstract_Factory
{
    class AnimalWorld_Client
    {
        private IPlantEater _plantEater;
        private IMeatEater _meatEater;

        public AnimalWorld_Client(IContinentFactory continent)
        {
            _plantEater = continent.CreatePlantEater();
            _meatEater = continent.CreateMeatEater();
        }

        public string RunFoodChain()
        {
            return _meatEater.Eat(_plantEater);
        }
    }
}
