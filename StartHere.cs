using System;
using UnityEngine;

namespace Asteroids
{
    internal sealed class StartHere : MonoBehaviour
    {
        [SerializeField] private int numberofEmenies;
        [SerializeField] private int enemyhp;
        private void Start()
        {
            var gm = new GameManager();
            gm.StartGame(numberofEmenies, enemyhp);
        }
    }
}