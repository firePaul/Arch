using UnityEngine;

namespace Asteroids.Observer
{
    public sealed class ListenerShowDeath
    {
        public void Add(IDestroyed value)
        {
            value.OnMeDestroyed += ValueDeath;
        }
        
        public void Remove(IDestroyed value)
        {
            value.OnMeDestroyed -= ValueDeath;
        }

        public void ValueDeath(string s)
        {
            Debug.Log(s);
        }
    }
}