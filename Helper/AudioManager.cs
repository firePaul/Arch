using System;
using UnityEngine;

namespace Helper
{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager instance;

        public AudioClip pickUp_Sound, dead_Sound;

        private void Awake()
        {
            MakeInstance();
        }

        private void MakeInstance()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public void Play_PickUpSound()
        {
            AudioSource.PlayClipAtPoint(pickUp_Sound, transform.position);
        }
        
        public void Play_DeadSound()
        {
            AudioSource.PlayClipAtPoint(dead_Sound, transform.position);
        }
    }
}