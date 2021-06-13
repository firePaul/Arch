using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        private readonly AudioSource _audioSource;
        private readonly IMuffler _muffler;
        private readonly Vector3 _mufflerPosition;
        private GameObject muffler;
        public ModificationMuffler(AudioSource audioSource, IMuffler muffler, Vector3 mufflerPosition)
        {
            _audioSource = audioSource;
            _muffler = muffler;
            _mufflerPosition = mufflerPosition;
        }
        
        protected override Weapon AddModification(Weapon weapon)
        {
            muffler = Object.Instantiate(_muffler.MufflerInstance, _mufflerPosition, Quaternion.identity);
            _audioSource.volume = _muffler.VolumeFireOnMuffler;
            weapon.SetAudioClip(_muffler.AudioClipMuffler);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }

        protected override Weapon RemoveModification(Weapon weapon)
        {
            weapon.SetBarrelPosition(Weapon._barrelPosition);
            _audioSource.volume = 1.0f;
            Object.Destroy(muffler);
            return weapon;
        }

        public Weapon RemoveMuffler(Weapon weapon)
        {
            weapon.SetBarrelPosition(Weapon._barrelPosition);
            _audioSource.volume = 1.0f;
            Object.Destroy(muffler);
            return weapon;
        }
    }

}