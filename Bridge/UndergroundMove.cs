﻿using UnityEngine;

namespace Asteroids.Bridge
{
    public class UndergroundMove : IMove
    {
        public void Move()
        {
            Debug.Log($"{this.GetType().Name}");
        }
    }
}