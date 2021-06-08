using System;
using UnityEngine;

namespace Asteroids.ServiceLocator
{
    public class ExampleServiceLocator : MonoBehaviour
    {
        private void Start()
        {
            ServiceLocator.GetService<ObjectPool.ObjectPool>();
        }
    }
}