using UnityEngine;

namespace Asteroids.Decorator
{
    public interface IScope
    {
        Camera Camera { get; }
        float CameraScope { get; }
        Transform GunPositionScope { get; }
        GameObject ScopeInstance { get; }
    }
}