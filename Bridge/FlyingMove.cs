using UnityEngine;

namespace Asteroids.Bridge
{
    public class FlyingMove : IMove
    {
        public void Move()
        {
            Debug.Log($"{this.GetType().Name}");
        }
    }
}