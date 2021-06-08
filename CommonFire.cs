using System.Collections;
using System.Collections.Generic;
using UnityEngine;

internal class CommonFire : MonoBehaviour , IFire 
{
    private readonly Rigidbody2D _bullet;
    private readonly Vector2 _startposition;
    private readonly Quaternion _startrotation;
    private readonly float _force;

    public CommonFire(Rigidbody2D bullet, Vector2 startposition, Quaternion startrotation, float force)
    {
        _bullet = bullet;
        _startposition = startposition;
        _startrotation = startrotation;
        _force = force;
    }
    
    public void Fire(Rigidbody2D _bullet, Vector2 _startposition, Quaternion _startrotation, float _force)
    {
        var temAmmunition = Instantiate(_bullet, _startposition, _startrotation);
        temAmmunition.AddForce(_startposition * _force);
    }
}
