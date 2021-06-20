using UnityEngine;

namespace Asteroids.Bridge
{
    public class ColdAttack: IAttack
    {
        public void Attack()
        {
            Debug.Log($"{this.GetType().Name}");
        }

    }
}