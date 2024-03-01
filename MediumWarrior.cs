namespace GameWarriors
{
    internal class MediumWarrior : IWarrior
    {
        readonly static double _maxHealthPoints = 15;
        readonly static double _damage = 1;
        readonly static double _defence = 1.2;
        readonly static double _cost = 7;
        readonly static double _dodge = 0.17;
        public double MaxHealthPoints { get => _maxHealthPoints; }
        public double HealthPoints { get; set; }
        public double Damage { get => _damage; }
        public double Defence { get => _defence; }
        public double Cost { get => _cost; }
        public double Dodge { get => _dodge; }
        public MediumWarrior()
        {
            HealthPoints = _maxHealthPoints;
        }
    }
}
