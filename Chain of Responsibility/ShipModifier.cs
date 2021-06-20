namespace Asteroids.Chain_of_Responsibility
{
    internal class ShipModifier
    {
        protected Player _player;
        protected ShipModifier Next;

        public ShipModifier(Player player)
        {
            _player = player;
        }

        public void Add(ShipModifier sm)
        {
            if (Next != null)
            {
                Next.Add(sm);
            }
            else
            {
                Next = sm;
            }
        }

        public virtual void Handle() => Next?.Handle();
    }
}