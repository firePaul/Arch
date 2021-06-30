using System;
using Helper;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


namespace MVVM
{
    public class ApplyScoreView : MonoBehaviour
    {
        private int score;
        private ITouchViewModel _touchViewModel;
        private UnityEvent _unityEvent;
        private Move move;
        private void Awake()
        {
            _unityEvent = new UnityEvent();
            move = GameObject.Find("Snake").GetComponent<Move>();
        }

        public void Initialize(ITouchViewModel touchViewModel)
        {
            _touchViewModel = touchViewModel;
            _unityEvent.AddListener(DoStuff);
        }

        private void OnTriggerEnter(Collider other)
        {
            _unityEvent.Invoke();
           
        }

        private void DoStuff()
        { 
            if (score > 0)
            {
                move._createNodeAtTail = true;
                AudioManager.instance.Play_PickUpSound();
            }
            else
            {
                AudioManager.instance.Play_DeadSound();
            }
            _touchViewModel.ApplyScore(score);
            gameObject.SetActive(false);
        }

        public void SetScore(int sc)
        {
            score = sc;
        }
    }
}