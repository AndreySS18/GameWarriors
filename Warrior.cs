namespace GameWarriors
{
    internal interface IWarrior
    {
        readonly static double _maxHealthPoints;
        readonly static double _damage;
        readonly static double _defence;
        readonly static double _cost;
        readonly static double _dodge;
        public double MaxHealthPoints { get; }
        public double HealthPoints { get; set; }
        public double Damage { get; }
        public double Defence { get; }
        public double Cost { get; }
        public double Dodge { get; }
    }
}
