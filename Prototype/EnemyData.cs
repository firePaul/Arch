using System;
using Fire;

namespace Prototype
{
    [Serializable]
    
    public class EnemyData : ICloneable
    {
        public float speed;
        public HealthPoints hp;

        public override string ToString()
        {
            return $"Speed {speed} Hp {hp}"; 
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}