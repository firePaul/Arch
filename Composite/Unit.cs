using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace DefaultNamespace
{
    public class Unit : MonoBehaviour
    {
        private UnitType _type;
        private Health _hp;
        
        public Unit(string type, int health)
        {
            _type = new UnitType(type);
            _hp = new Health(health);
        }
        
        public void SetType(string type)
        {
            _type = new UnitType(type);
        }
        
        public void SetHealth(int health)
        {
            _hp = new Health(health);
        }
    }
}