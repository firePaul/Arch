using Asteroids.Enemy;
using Fire;
using UnityEngine;

namespace Prototype
{
    public sealed class EnemyShipPrototype : MonoBehaviour
    {
        public static void MakeEnemyShipPrototype()
            {
                EnemyData enemyData = new EnemyData
                {
                    hp = new HealthPoints()
                    {
                        CurrentHP = 100,
                        MaxHP = 100
                    },
                    speed = 100
                };
                
                EnemyData enemyDataNew = enemyData.DeepCopy();
                enemyDataNew.hp.MaxHP = 300;
                enemyDataNew.hp.CurrentHP =300;
                enemyDataNew.speed = 200;
                
                Debug.Log(enemyData);
                Debug.Log(enemyDataNew);

                var enemy = Instantiate(Resources.Load<EnemyShip>("Enemy/EnemyShip"));
            }
    } 
}