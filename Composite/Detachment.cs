using System.Collections.Generic;
using UnityEngine.UIElements;

namespace DefaultNamespace
{
    internal sealed class Detachment
    {
        private List<IBuildUnit> _buildUnits = new List<IBuildUnit>();
        private List<string> _types = new List<string>();
        private List<int> _healths = new List<int>();
        public void AddFactory(IBuildUnit factory, string type, int health)
        {
            _buildUnits.Add(factory);
            _types.Add(type);
            _healths.Add(health);
        }
        
        public void RemoveUnit(IBuildUnit factory, string type, int health)
        {
            _buildUnits.Remove(factory);
            _types.Remove(type);
            _healths.Remove(health);
        }
        
        public void BuildUnits()
        {
            for (int i = 0; i < _buildUnits.Capacity-1; i++)
            {
                _buildUnits[i].BuildUnit(_types[i], _healths[i]);
            }
        }
    }

}