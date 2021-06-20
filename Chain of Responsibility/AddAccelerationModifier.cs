namespace Asteroids.Chain_of_Responsibility
{
    internal sealed class AddAccelerationModifier : ShipModifier
    {
        private readonly float _acceleration;

        public AddAccelerationModifier(Player player, float acc) 
            : base(player)
        {
            _acceleration = acc;
        }

        public override void Handle()
        {
            _player._acceleration += _acceleration; 
            base.Handle();
        }
    }
}