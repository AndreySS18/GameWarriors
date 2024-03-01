namespace GameWarriors
{
    internal class LightWarrior : IWarrior
    {
        readonly static double _maxHealthPoints = 10;
        readonly static double _damage = 2;
        readonly static double _defence = 0.8;
        readonly static double _cost = 5;
        readonly static double _dodge = 0.17;
        public double MaxHealthPoints { get => _maxHealthPoints; }
        public double HealthPoints { get; set; }
        public double Damage { get => _damage; }
        public double Defence { get => _defence; }
        public double Cost { get => _cost; }
        public double Dodge { get => _dodge; }
        public LightWarrior()
        {
            HealthPoints = _maxHealthPoints;
        }
    }
}
