using UnityEngine;

namespace Asteroids
{
    internal class MoveTransform : IMove
    {
        private readonly Rigidbody2D _rigidbody2D;
        private Vector2 _move;

        public float Speed { get; protected set; }
        
        public MoveTransform(Rigidbody2D rigidbody2D, float speed)
        {
            _rigidbody2D = rigidbody2D;
            Speed = speed;
        }

        public void Move(float horizontal, float vertical,  float deltaTime)
        {
            var speed = deltaTime * Speed;
            _move = new Vector2(horizontal * speed, vertical * speed);
            _rigidbody2D.velocity = _move * speed;
        }
    }
}
