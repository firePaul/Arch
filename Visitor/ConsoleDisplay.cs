using UnityEngine;

namespace Asteroids.Visitor
{
    public sealed class ConsoleDisplay : IHere
    {
        public void Visit(VisitorEnemy onrevive, string im)
        {
            Debug.Log($"{nameof(VisitorEnemy)} - {im}");
        }
    }
}