using Prototype;
using UnityEngine;
using HealthPoints = Fire.HealthPoints;

namespace Asteroids
{
    internal sealed class Player : MonoBehaviour
    {
        [SerializeField] private Rigidbody _body;
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private int _hp;
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private int _damageonhit;
        private Camera _camera;
        private Ship _ship;

        private void Awake()
        {
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(_body, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            var commonFire = new CommonFire(_bullet, _barrel.position, _barrel.rotation);
            var takeDamage = gameObject.AddComponent<HealthPoints>();
            takeDamage.SetHP(_hp);
            _ship = new Ship(moveTransform, rotation, commonFire, takeDamage);
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
        }

    }
}
