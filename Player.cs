using Asteroids.Memento;
using Fire;
using Prototype;
using UniRx;
using UnityEngine;
using HealthPoints = Fire.HealthPoints;

namespace Asteroids
{
    public sealed class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody _body;
        public float _speed;
        public float _acceleration;
        public int _hp;
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private int _damageonhit;
        private Camera _camera;
        private Ship _ship;
        private Reverse5s Reverse5S;
        
        private void Awake()
        {
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(_body, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            var commonFire = new CommonFire(_bullet, _barrel.position, _barrel.rotation);
            var takeDamage = gameObject.AddComponent<HealthPoints>();
            takeDamage.SetHP(_hp);
            _ship = new Ship(moveTransform, rotation, commonFire, takeDamage);
            MessageBroker.Default.Receive<Message>().Where(x => x.Name == Message.LoL).Subscribe(_ =>LolSomeOneDie()).AddTo(this);

            Reverse5S = GetComponent<Reverse5s>();
        }

        private void Update()
        {


            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);

            _ship.Move(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }

            if (Input.GetButtonDown("Fire1"))
            {
                _ship.Fire(_bullet, _barrel.position, _barrel.rotation);
            }

            if (Input.GetKeyDown(KeyCode.LeftAlt))
            {
                EnemyShipPrototype.MakeEnemyShipPrototype();
            }


            if (Input.GetKeyDown(KeyCode.Q))
            {
                Reverse5S.StartRewind();
            }

            if (Input.GetKeyUp(KeyCode.Q))
            {
                 Reverse5S.StopRewind();
            }


        }

        private void LolSomeOneDie()
        {
            Debug.Log("LoL SomeOne Die");
        }

    }
}
