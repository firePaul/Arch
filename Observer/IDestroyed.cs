using System;

namespace Asteroids.Observer
{
    public interface IDestroyed
    {
        event Action<string> OnMeDestroyed;

        public void Destroyed(string s);
    }
}