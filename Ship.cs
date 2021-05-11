using UnityEngine;

namespace Asteroids
{
    internal sealed class Ship : IMove, IRotation, IFire
    {
        private readonly IMove _moveImplementation;
        private readonly IRotation _rotationImplementation;
        private readonly IFire _fireImplementation;
        private readonly ITakeDamage _takeDamageImplementation;

        public float Speed => _moveImplementation.Speed;

        public Ship(IMove moveImplementation, IRotation rotationImplementation, IFire fireImplementation, ITakeDamage takeDamageImplementation)
        {
            _moveImplementation = moveImplementation;
            _rotationImplementation = rotationImplementation;
            _fireImplementation = fireImplementation;
            _takeDamageImplementation = takeDamageImplementation;
        }

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplementation.Move(horizontal, vertical, deltaTime);
        }

        public void Rotation(Vector3 direction)
        {
            _rotationImplementation.Rotation(direction);
        }

        public void Fire(Rigidbody2D bullet, Vector2 startposition, Quaternion startrotation, float force)
        {
            _fireImplementation.Fire(bullet, startposition, startrotation, force);
        }

        public void TakeDamage(int damage)
        {
            _takeDamageImplementation.TakeDamage(damage);
        }
        public void AddAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }
    }
}
