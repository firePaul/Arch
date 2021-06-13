using System.Collections;
using System.Collections.Generic;
using Asteroids;
using Asteroids.Bullets;
using Asteroids.Enemy;
using Asteroids.ObjectPool;
using Fire;
using UnityEngine;

internal sealed class GameManager : MonoBehaviour
{
   public void StartGame(int numberofEnemies, int enemyhp)
    {
        CreatePlayer();
        for (int i = 0; i < numberofEnemies; i++)
        {
            CreateEnemyShip(enemyhp); 
        }
        
    }

    private Player CreatePlayer()
    {
        var player = Instantiate(Resources.Load<Player>("Enemy/Player"));
        return player;
    }

    private void CreateEnemyShip(int hp)
    {
        EnemyFactory.CreateEnemyShip(new HealthPoints(hp));
    }
}
