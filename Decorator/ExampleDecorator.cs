using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ExampleDecorator : MonoBehaviour
    {
        private IFire _fire;
        [Header("Start Gun")]
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] public AudioClip _audioClip;

        [Header("Muffler Gun")] 
        [SerializeField] private AudioClip _audioClipMuffler;
        [SerializeField] private float _volumeFireOnMuffler;
        [SerializeField] private Transform _barrelPositionMuffler;
        [SerializeField] private GameObject _muffler;
        private bool MufflerOn=false;
        private ModificationMuffler _modificationMuffler;
        private Muffler muffler;
        
        [Header("Scope Gun")] 
        [SerializeField] private Camera _camera;
        [SerializeField] private float _cameraScope;
        [SerializeField] private Transform _gunPositionScope;
        [SerializeField] private GameObject _scopeInstance;
        private bool ScopeOn=false;
        private ModificationScope _modificationScope;
        private Scope scope;
        
        private Weapon _weapon;
        private ModificationWeapon _preweapon;
        private ModificationWeapon _modificationWeapon;
        private void Start()
        {
            IAmmunition ammunition = new Bullet(_bullet, 3.0f);
            _weapon = new Weapon(ammunition, _barrelPosition, 999.0f, _audioSource, _audioClip);
            _fire = _weapon;
            muffler = new Muffler(_audioClipMuffler, _volumeFireOnMuffler, _barrelPosition, _muffler);
            scope = new Scope(_camera, _cameraScope, _gunPositionScope, _scopeInstance);
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (!MufflerOn)
                {
                    _modificationMuffler = new ModificationMuffler(_audioSource, muffler, _barrelPositionMuffler.position);
                    _modificationMuffler.ApplyModification(_weapon);
                    MufflerOn = true;
                    _fire = _modificationMuffler;
                }
                else
                {
                    MufflerOn = false;
                    _weapon.SetAudioClip(_audioClip);
                    _modificationMuffler.RemoveMuffler(_weapon);
                    _fire = _modificationMuffler;
                }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (!ScopeOn)
                {
                    
                    _modificationScope = new ModificationScope(_camera, scope, _cameraScope);
                    _modificationScope.ApplyModification(_weapon);
                    ScopeOn = true;
                    _fire = _modificationScope;
                }
                else
                {
                    ScopeOn = false;
                    _modificationScope.RemoveScope(_weapon);
                    _fire = _modificationScope;
                }
            }
        }
    }

}