using System;
using Asteroids.Enemy;
using TMPro;
using UnityEngine;

namespace Asteroids.Observer
{
    internal sealed class ObsTest : MonoBehaviour
    {
        public EnemyShip Enemy;
        private string s;
        public TMP_Text text;
        
        private void Start()
        {
            s = $"I'm {Enemy.name} destroyed";
            var listenerShowDeath = new ListenerShowDeath();
            listenerShowDeath.Add(Enemy);
        }

        private void OnDisable()
        {
            if(TryGetComponent<IDestroyed>(out var Destroyed))
            {
                Enemy.Destroyed(s);
                MeDestroyed();
            }
        }

        private void MeDestroyed()
        {
            text.text = s;
            Invoke(nameof(StopShow),3);
        }

        private void StopShow()
        {
            text.text = "";
        }
    }
}