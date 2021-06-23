using System;
using UniRx;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Fire
{
    
    internal sealed class HealthPoints : MonoBehaviour, ITakeDamage
    {
        private int _hp { get; set; }
        public HealthPoints(int hp)
        {
            _hp = hp;
        }

        public void TakeDamage(int damage)
        {
            _hp -= damage;
            if (_hp - damage <= 0)
            {
                gameObject.SetActive(false);
                //Debug.Log("LoL u Die");
                MessageBroker.Default.Publish(new Message(Message.LoL));
            }
        }

        public void SetHP(int hp)
        {
            _hp = hp;
        }
    
        public override string ToString()
        {
            return $"Health Points {_hp}";
        }
    }
}


