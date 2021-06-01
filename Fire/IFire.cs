using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFire 
{
    void Fire(Rigidbody bullet,Vector3 startposition,Quaternion startrotation);
}
