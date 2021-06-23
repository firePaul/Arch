using UnityEngine;

namespace Asteroids.Bridge
{
    public class FireAttack : IAttack
    {
        public void Attack()
        {
            Debug.Log($"{this.GetType().Name}");
        }

    }
}