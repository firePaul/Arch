using UnityEngine;

namespace Asteroids.Bridge
{
    public class SwimmingMove : IMove
    {
        public void Move()
        {
            Debug.Log($"{this.GetType().Name}");
        }
    }
}