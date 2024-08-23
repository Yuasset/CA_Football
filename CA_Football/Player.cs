namespace CA_Football
{
    internal abstract class Player : Team
    {
        public string Name { get; set; }

        public abstract string Run(int tempValue);

        public abstract string Shoot(int tempValue);

        public abstract string Feint(int tempValue);

        public abstract string Pressing(int tempValue);
    }
}
