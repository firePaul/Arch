namespace Asteroids.State
{
    public class State
    {
        protected ShipMoveState character;
        protected StateMachine stateMachine;

        protected State(ShipMoveState character, StateMachine stateMachine)
        {
            this.character = character;
            this.stateMachine = stateMachine;
        }

        public virtual void Enter()
        {
            DisplayOnUI(UIManager.Alignment.Left);
        }

        public virtual void HandleInput()
        {

        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void PhysicsUpdate()
        {

        }

        public virtual void Exit()
        {

        }

        protected void DisplayOnUI(UIManager.Alignment alignment)
        {
            UIManager.Instance.Display(this, alignment);
        }
    }
}