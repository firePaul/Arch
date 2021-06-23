using UnityEngine;

namespace Asteroids.Bridge
{
    public class ChaosAttack : IAttack
    {
        public void Attack()
        {
            Debug.Log($"{this.GetType().Name}");
        }

    }
}