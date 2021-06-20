using System;
using UnityEngine;

namespace Asteroids.Proxy
{
    internal sealed class ProxyExample : MonoBehaviour
    {
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrel;

        private bool unfire;
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                var unlockFire = new UnlockFire(unfire);
                var fire = new CommonFire(_bullet, _barrel.position, _barrel.rotation);
                var fireProxy = new FireProxy(fire, unlockFire);
                fireProxy.Fire(_bullet, _barrel.position, _barrel.rotation);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                if (unfire)
                {
                    unfire = false;
                }
                else
                {
                    unfire = true;
                }
            }
        }
    }
}