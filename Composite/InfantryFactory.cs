using UnityEngine;

namespace DefaultNamespace
{
    public class InfantryFactory : MonoBehaviour, IBuildUnit
    {
        public Unit BuildUnit(string type, int hp)
        {
            var infantry =Instantiate(Resources.Load<Unit>("Enemy/Infantry"));
            infantry.SetType("infantry");
            infantry.SetHealth(hp);
            return infantry;
        }
    }
}