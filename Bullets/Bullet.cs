using System;
using Fire;
using UnityEngine;

namespace Asteroids.Bullets
{
    public class Bullet:MonoBehaviour
    {
        private Rigidbody _pb;
        [SerializeField] private float _speed = 2000f;
        [SerializeField] private int _damage = 50;

        
        private void OnEnable()
        {
            _pb = gameObject.GetComponent<Rigidbody>();
            Shoot();
        }

        private void Shoot()
        {
            _pb.AddForce(transform.forward * _speed, ForceMode.Force);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Hit Player");
                other.GetComponent<HealthPoints>().TakeDamage(_damage);
                gameObject.SetActive(false);
                
            }
            if(other.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Hit Enemy");
                other.GetComponent<HealthPoints>().TakeDamage(_damage);
                gameObject.SetActive(false);
            }
        }
    }
}
