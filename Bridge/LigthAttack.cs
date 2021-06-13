using UnityEngine;

namespace Asteroids.Bridge
{
    public class LigthAttack : IAttack
    {
        public void Attack()
        {
            Debug.Log($"{this.GetType().Name}");
        }

    }
}