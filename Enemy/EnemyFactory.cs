using Fire;
using Unity.CodeEditor;
using UnityEngine;

namespace Asteroids.Enemy
{
    internal  abstract class EnemyFactory : MonoBehaviour
    {
        public HealthPoints HealthPoints { get; private set; }

        public static EnemyShip CreateEnemyShip(HealthPoints hp)
        {
            var enemy = Instantiate(Resources.Load<EnemyShip>("Enemy/EnemyShip"));
            enemy.HealthPoints = hp;

            return enemy;
        }
    }
}