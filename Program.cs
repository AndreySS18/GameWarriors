namespace GameWarriors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var varior = new LightWarrior();
            Console.WriteLine(varior.HealthPoints);
            Console.WriteLine(varior.Defence);
            Console.WriteLine(varior.Damage);
            varior.HealthPoints -=5;
            Console.WriteLine(varior.HealthPoints);
            Console.WriteLine(varior.Defence);
            Console.WriteLine(varior.Damage);
        }
    }
}