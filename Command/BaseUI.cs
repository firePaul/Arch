using UnityEngine;

namespace DefaultNamespace
{
    internal abstract class BaseUI : MonoBehaviour
    {
        public abstract void Execute();  
        public abstract void Cancel();
    }
}