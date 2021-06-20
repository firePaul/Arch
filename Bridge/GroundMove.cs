using UnityEngine;

namespace Asteroids.Bridge
{
    public class GroundMove: IMove
    {
        public void Move()
        {
            Debug.Log($"{this.GetType().Name}");
        }
    }
}