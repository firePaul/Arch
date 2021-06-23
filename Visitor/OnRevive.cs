using UnityEngine;

namespace Asteroids.Visitor
{
    public abstract  class OnRevive : MonoBehaviour
    {
         public TextMesh TextMesh;
         public abstract void Activate(IHere value);
    }
}