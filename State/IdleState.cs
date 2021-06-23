using UnityEngine;

namespace Asteroids.State
{
    public class IdleState : FlyState
    {
        
        public IdleState(ShipMoveState character, StateMachine stateMachine) : base(character, stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            speed = character.MovementSpeed;
            rotationSpeed = character.RotationSpeed;
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            base.LogicUpdate();
        }
    }
}