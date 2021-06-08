using System.Collections;
using System.Collections.Generic;
using Asteroids.Bullets;
using Asteroids.ObjectPool;
using UnityEngine;

internal class CommonFire : IFire 
{
    private readonly Rigidbody _bullet;
    private readonly Vector2 _startposition;
    private readonly Quaternion _startrotation;
    
    

    public CommonFire(Rigidbody bullet, Vector3 startposition, Quaternion startrotation)
    {
        _bullet = bullet;
        _startposition = startposition;
        _startrotation = startrotation;
 
    }
    
    public void Fire(Rigidbody _bullet, Vector3 _startposition, Quaternion _startrotation)
    {
        GameObject bullet = ObjectPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = _startposition; 
            bullet.transform.rotation = _startrotation; 
            bullet.SetActive(true);
        }
    }
}
