using UnityEngine;

namespace Asteroids.Bridge
{
    public class PhysicalAttack : IAttack
    {
        public void Attack()
        {
            Debug.Log($"{this.GetType().Name}");
        }

    }
}