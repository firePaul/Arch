namespace Asteroids.Chain_of_Responsibility
{
    internal sealed class AddSpeedModifier : ShipModifier
    {
        private readonly float _speed;

        public AddSpeedModifier(Player player, float speed) 
            : base(player)
        {
            _speed = speed;
        }

        public override void Handle()
        {
            _player._speed += _speed;
            base.Handle();
        }
    }

}