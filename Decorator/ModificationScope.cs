using UnityEngine;

namespace Asteroids.Decorator
{
    internal sealed class ModificationScope : ModificationWeapon
    {
        private readonly Camera _camera;
        private readonly IScope _scope;
        private readonly float _cameraPosition;
        private GameObject scope;
        public ModificationScope(Camera camera, IScope scope, float cameraPosition)
        {
        _camera=camera;
        _scope=scope;
        _cameraPosition=cameraPosition;
        }
        
        protected override Weapon AddModification(Weapon weapon)
        {
            scope = Object.Instantiate(_scope.ScopeInstance, _scope.GunPositionScope.position, _scope.GunPositionScope.rotation);
            _camera.gameObject.transform.position=new Vector3(_camera.gameObject.transform.position.x,_camera.gameObject.transform.position.y,_camera.gameObject.transform.position.z + _cameraPosition);
            return weapon;
        }

        protected override Weapon RemoveModification(Weapon weapon)
        {
            _camera.gameObject.transform.position=new Vector3(_camera.gameObject.transform.position.x,_camera.gameObject.transform.position.y,_camera.gameObject.transform.position.z - _cameraPosition);
            Object.Destroy(scope);
            return weapon;
        }

        public Weapon RemoveScope(Weapon weapon)
        {
            _camera.gameObject.transform.position=new Vector3(_camera.gameObject.transform.position.x,_camera.gameObject.transform.position.y,_camera.gameObject.transform.position.z - _cameraPosition);
            Object.Destroy(scope);
            return weapon;
        }
    }
}