using System.Collections;
using System.Collections.Generic;
using UnityEngine;


internal class SomethingTakeDamage : MonoBehaviour, ITakeDamage
{
    private int _hp;
    public SomethingTakeDamage(int hp)
    {
        _hp = hp;        
    }

    public void TakeDamage(int damage)
    {
        if (_hp-damage <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            _hp=_hp-damage;
        }
    }
}


