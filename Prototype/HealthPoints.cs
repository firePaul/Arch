using System;

namespace Prototype
{
    [Serializable]
    public class HealthPoints
    {
        public float MaxHP;
        public float CurrentHP;

        public override string ToString()
        {
            return $"MaxHP {MaxHP} CurrentHP {CurrentHP}";
        }
    }
}