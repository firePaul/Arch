using UnityEngine;

namespace Asteroids.State
{
    public class ShipMoveState : MonoBehaviour
    {
        public StateMachine movementSM;
        public IdleState Idle;
        public float MovementSpeed = 150f;
        public float RotationSpeed = 60f;
        
        
        private void Start()
        {
            movementSM = new StateMachine();
            
            Idle = new IdleState(this, movementSM);
            
            movementSM.Initialize(Idle);
        }

        private void Update()
        {
            movementSM.CurrentState.HandleInput();

            movementSM.CurrentState.LogicUpdate();
        }

        private void FixedUpdate()
        {
            movementSM.CurrentState.PhysicsUpdate();
        }
        
        public void Move(float speed, float rotationSpeed)
        {
            Vector3 targetVelocity = speed * transform.forward * Time.deltaTime;
            targetVelocity.y = GetComponent<Rigidbody>().velocity.y;
            GetComponent<Rigidbody>().velocity = targetVelocity;

            GetComponent<Rigidbody>().angularVelocity = rotationSpeed * Vector3.up * Time.deltaTime;
            
        }
        
        public void ResetMoveParams()
        {
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
        
        public void ApplyImpulse(Vector3 force)
        {
            GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
        }
    }
}