using UnityEngine;

namespace Asteroids.Proxy
{
    public sealed class FireProxy : IFire
    {

        private readonly IFire _fire;
        private readonly UnlockFire _unlockFire;

        public FireProxy(IFire fire, UnlockFire unlockFire)
        {
            _fire = fire;
            _unlockFire = unlockFire;
        }
        
        public void Fire(Rigidbody bullet, Vector3 startposition, Quaternion startrotation)
        {
            if (_unlockFire.IsUnlock)
            {
                _fire.Fire(bullet,startposition,startrotation);
            }
            else
            {
                Debug.Log("Weapon is lock");
            }
        }
    }
}