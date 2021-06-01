using System;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.AI;

namespace Asteroids.Enemy
{
    internal sealed class EnemyShip : EnemyFactory
    {
        [SerializeField] private Rigidbody _body;
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private int _hp;
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrel;
        private NavMeshAgent _agent=null;
        private GameObject _player=null;
        private Ship _ship;
        private bool fire=true;

        
        private void Awake()
        {
            
            var moveTransform = new AccelerationMove(_body, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            var commonFire = new CommonFire(_bullet, _barrel.position, _barrel.rotation);
            var takeDamage = new HealthPoints(_hp);
            _ship = new Ship(moveTransform, rotation, commonFire, takeDamage);
            
            _agent = GetComponent<NavMeshAgent>();
            _player = GameObject.FindWithTag("Player");
            _agent.stoppingDistance=30f;
        }

        private void Update()
        {
            _agent.SetDestination(_player.transform.position);
            if (_agent.remainingDistance <= 100)
            {
                _agent.transform.LookAt(_player.transform);
                if(fire)
                {
                    Invoke("FireAtPlayer",1f);
                    fire = false;
                }
                
            }
        }

        public void FireAtPlayer()
        {
            _ship.Fire(_bullet,_barrel.position,_barrel.rotation);
            fire = true;
        }
    }
}