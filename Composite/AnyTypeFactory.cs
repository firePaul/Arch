using UnityEngine;

namespace DefaultNamespace
{
    public class AnyTypeFactory : MonoBehaviour, IBuildUnit
    {
        public Unit BuildUnit(string type, int hp)
        {
            var unit =Instantiate(Resources.Load<Unit>($"Enemy/{type}"));
            unit.SetType(type);
            unit.SetHealth(hp);
            return unit;
        }
    }
}