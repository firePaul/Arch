using UnityEngine;

namespace Asteroids.Bridge
{
    public class Example : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                var enemy = new CreatureForTest(new ColdAttack(),new GroundMove());
                enemy.Attack();
                enemy.Move();
            }
            
            if (Input.GetKeyDown(KeyCode.X))
            {
                var enemy = new CreatureForTest(new FireAttack(),new UndergroundMove());
                enemy.Attack();
                enemy.Move();
            }
            
            if (Input.GetKeyDown(KeyCode.C))
            {
                var enemy = new CreatureForTest(new ChaosAttack(),new FlyingMove());
                enemy.Attack();
                enemy.Move();
            }
            
            if (Input.GetKeyDown(KeyCode.V))
            {
                var enemy = new CreatureForTest(new ColdAttack(),new FlyingMove());
                enemy.Attack();
                enemy.Move();
            }
        }
        
    }

}