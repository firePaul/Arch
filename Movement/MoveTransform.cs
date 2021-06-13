using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform : IMove
    {
        private readonly Rigidbody _rigidbody;
        private Vector3 _move;

        public float Speed { get; protected set; }
        
        public MoveTransform(Rigidbody rigidbody, float speed)
        {
            _rigidbody = rigidbody;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical,  float deltaTime)
        {
            var speed = deltaTime * Speed;
            _move = new Vector3(horizontal * speed, vertical * speed);
            _rigidbody.velocity = _move * speed;
        }
    }
}
