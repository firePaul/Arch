using UnityEngine;

namespace Asteroids.Chain_of_Responsibility
{
    public class GiveBoost : MonoBehaviour
    {
        private Player _player;
        private GameObject _goPlayer;

        private void Start()
        {
            _goPlayer = GameObject.FindGameObjectWithTag("Player");
            _player = _goPlayer.GetComponent<Player>();

            var root = new ShipModifier(_player);
            root.Add(new AddSpeedModifier(_player, 200));
            root.Add(new AddAccelerationModifier(_player, 200));
            root.Add(new AddHPModfier(_player, 500));
            root.Handle();
        }
    }
}