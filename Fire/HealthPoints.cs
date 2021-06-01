using System.Collections;
using System.Collections.Generic;
using UnityEngine;


internal sealed class HealthPoints : MonoBehaviour, ITakeDamage
{
    public int _hp { get; private set; }

    public HealthPoints(int hp)
    {
        _hp = hp;
    }

    public void TakeDamage(int damage)
    {
        _hp -= damage;
        if (_hp - damage <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SetHP(int hp)
    {
        _hp = hp;
    }
}


