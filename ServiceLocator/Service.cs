using UnityEngine;

namespace Asteroids.ServiceLocator
{
    public class Service : IService
    {
        public void DoService()
        {
            Debug.Log(nameof(Service));
        }
    }
}