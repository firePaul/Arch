namespace Asteroids.Proxy
{
    public sealed class UnlockFire
    {
        public bool IsUnlock { get; set; }

        public UnlockFire(bool isUnlock)
        {
            IsUnlock = isUnlock;
        }
    }
}