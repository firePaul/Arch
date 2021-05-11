using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFire 
{
    void Fire(Rigidbody2D bullet,Vector2 startposition,Quaternion startrotation, float force);
}
