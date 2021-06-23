using Asteroids.Bullets;
using UnityEngine;

namespace Asteroids.Fluent_Builder
{
    public static partial class Builder
    {
        public static GameObject SetName(this GameObject gameObject, string name)
        {
            gameObject.name = name;
            return gameObject;
        }
        
        public static GameObject AddRigidBody(this GameObject gameObject, float mass, bool gravity)
        {
            var component = gameObject.GetOrAddComponent<Rigidbody>();
            component.useGravity = gravity;
            component.mass = mass;
            return gameObject;
        }
        
        public static GameObject AddMeshRenderer(this GameObject gameObject, Material material)
        {
            var component = gameObject.GetOrAddComponent<MeshRenderer>();
            component.material = material;
            return gameObject;
        }
        
        public static GameObject AddMeshFilter(this GameObject gameObject, Mesh mesh)
        {
            var component = gameObject.GetOrAddComponent<MeshFilter>();
            component.mesh = mesh;
            return gameObject;
        }
        
        
        public static GameObject AddSphereCollider(this GameObject gameObject, bool trigger)
        {
            var component = gameObject.GetOrAddComponent<SphereCollider>();
            component.isTrigger = trigger;
            return gameObject;
        }

        public static GameObject AddBulletScript(this GameObject gameObject)
        {
            var component = gameObject.GetOrAddComponent<Bullet>();
            return gameObject;
        }
        private static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            var result = gameObject.GetComponent<T>();
            if (!result)
            {
                result = gameObject.AddComponent<T>();
            }
            return result;
        }
    }
}