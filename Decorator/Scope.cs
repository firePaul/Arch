using UnityEngine;

namespace Asteroids.Decorator
{
    public class Scope : IScope
    {
        public Camera Camera { get; }
        public float CameraScope { get; }
        public Transform GunPositionScope { get; }
        public GameObject ScopeInstance { get; }

        public Scope(Camera camera, float cameraScope, Transform gunPositionScope, GameObject scopeInstance)
        {
            Camera = camera;
            CameraScope = cameraScope;
            GunPositionScope = gunPositionScope;
            ScopeInstance = scopeInstance;
        }
    }
}