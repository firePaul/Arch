using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace PickUps
{
    public class DeactivatePickUp : MonoBehaviour
    {
        private void Start()
        {
            Invoke("Deactivate",Random.Range(10f,15f));
        }

        private void Deactivate()
        {
            gameObject.SetActive(false);
        }
    }
}