namespace Asteroids.Chain_of_Responsibility
{
    internal sealed class AddHPModfier : ShipModifier
    {
        private readonly int _hp;

        public AddHPModfier(Player player, int hp) 
            : base(player)
        {
            _hp = hp;
        }

        public override void Handle()
        {
            _player._hp += _hp;
            base.Handle();
        }
    }
}