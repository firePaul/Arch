using System.Collections;
using System.Collections.Generic;
using Asteroids.Bullets;
using Asteroids.Enemy;
using Asteroids.ObjectPool;
using Fire;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject Player;
    void Start()
    {
        GameObject.Instantiate(Player);
        
        EnemyFactory.CreateEnemyShip(new HealthPoints(100));
    }
}
