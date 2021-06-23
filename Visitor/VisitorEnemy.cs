namespace Asteroids.Visitor
{
    public class VisitorEnemy : OnRevive
    {
        public override void Activate(IHere value)
        {
            value.Visit(this, $"{nameof(this.name)} here");
        }
    }
}