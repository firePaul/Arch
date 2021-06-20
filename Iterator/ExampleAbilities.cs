using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Asteroids.Iterator
{
    internal class ExampleAbilities : MonoBehaviour
    {
        private void Start()
        {
            var ability = new List<IAbility>
            {
                new Ability("Big Rocket", 300, Target.Unit, DamageType.Physical),
                new Ability("Cannon Ball", 300, Target.None | Target.Autocast, DamageType.Physical),
                new Ability("Rapid Fire", -50, Target.Passive, DamageType.None),
                new Ability("Lighting Strike", 1000, Target.Unit, DamageType.Magical),
            };

            IPlayer player = new PlayerAbilities(ability);

            Debug.Log(player[0]);
            Debug.Log(new string('+', 50));
            Debug.Log(player[Target.Unit | Target.Autocast]);
            Debug.Log(new string('+', 50));
            Debug.Log(player[Target.Unit | Target.Passive]);
            Debug.Log(new string('+', 50));
            Debug.Log(player.MaxDamage);
            Debug.Log(new string('+', 50));
            foreach (var o in player)
            {
                Debug.Log(o);
            }

            Debug.Log(new string('+', 50));
            foreach (var o in player.GetAbility().Take(2))
            {
                Debug.Log(o);
            }

            Debug.Log(new string('+', 50));
            foreach (var o in player.GetAbility(DamageType.Magical))
            {
                Debug.Log(o);
            }
        }
    }
}