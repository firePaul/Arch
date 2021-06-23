using System;
using UnityEngine;

namespace Asteroids.Visitor
{
    public sealed class VisitorDisplay : MonoBehaviour
    {
        private void OnEnable()
        {
            if (gameObject.TryGetComponent<OnRevive>(out var here))
            {
                here.Activate(new ConsoleDisplay());
            }
        }
    }
}