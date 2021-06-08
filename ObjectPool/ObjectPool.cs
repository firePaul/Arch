using System.Collections.Generic;
using Asteroids.Fluent_Builder;
using UnityEngine;

namespace Asteroids.ObjectPool
{
    internal sealed class ObjectPool : MonoBehaviour
    {
        public static ObjectPool SharedInstance; 
        public List<GameObject> pooledObjects; 
        public GameObject objectToPool; 
        public int amountToPool;

        public Mesh mesh;
        public Material material;
        
        

        void Awake()
        {
            SharedInstance = this;
        }

        void Start()
        {
            pooledObjects = new List<GameObject>(); 
            //GameObject tmp;
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject bullet =new GameObject().SetName("BulletFromBuilder").AddMeshFilter(mesh).AddMeshRenderer(material).AddSphereCollider(true)
                    .AddRigidBody(1,false).AddBulletScript();
                //tmp = Instantiate(objectToPool); 
                bullet.SetActive(false); 
                pooledObjects.Add(bullet);
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < amountToPool; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            } return null;
        }
    }
}