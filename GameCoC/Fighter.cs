namespace GameCoC
{
    public class Fighter
    {
        public int Health { get; private set; }
        public int HitPoint { get; private set; }

        public Fighter(int health, int hitPoint)
        {
            Health = health;
            HitPoint = hitPoint;
        }
    }
}