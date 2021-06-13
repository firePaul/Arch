using UnityEngine;

namespace DefaultNamespace
{
    internal sealed class MageFactory : MonoBehaviour, IBuildUnit
    {
        public Unit BuildUnit(string type, int hp)
        {
            var mage =Instantiate(Resources.Load<Unit>("Enemy/Mage"));
            mage.SetType("mag");
            mage.SetHealth(hp);
            return mage;
        }
    }
}