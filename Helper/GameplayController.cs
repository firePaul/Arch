using System;
using System.Collections;
using MVVM;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Helper
{
    public class GameplayController : MonoBehaviour
    {
        public static GameplayController instance;
        [SerializeField] private TouchView _touchView;
        [SerializeField] private ApplyScoreView _applyScoreViewFruit;
        [SerializeField] private ApplyScoreView _applyScoreViewBomb;
        
        private TouchViewModel _touchViewModel;

        public GameObject fruit_PickUp, bomb_PickUp;

        private float min_X = -90f, max_X = 90f, min_Z = -40f, max_Z = 40f;
        private float y_Pos = 1f;

        private void Start()
        {
            MakeInstance();
            Application.targetFrameRate = 240;
            var Touchmodel = new TouchModel(0);
            _touchViewModel = new TouchViewModel(Touchmodel);
            _touchView.Initialize(_touchViewModel);
            Invoke("StartSpawning",0.5f);
        }

        private void MakeInstance()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        private void StartSpawning()
        {
            StartCoroutine((SpawnPickUps()));
        }

        public void CancelSpawnging()
        {
            CancelInvoke("StartSpawning");
        }

        IEnumerator SpawnPickUps()
        {
            yield return new WaitForSeconds(Random.Range(0.5f, 1f));

            if (Random.Range(0, 10) >= 2)
            {
                var fruit = Instantiate(fruit_PickUp, new Vector3(Random.Range(min_X, max_X),y_Pos,
                    Random.Range(min_Z, max_Z)), Quaternion.identity);
                _applyScoreViewFruit = fruit.AddComponent<ApplyScoreView>();
                _applyScoreViewFruit.SetScore(1);
                _applyScoreViewFruit.Initialize(_touchViewModel);
            }
            else
            {
                var bomb = Instantiate(bomb_PickUp, new Vector3(Random.Range(min_X, max_X),y_Pos,
                    Random.Range(min_Z, max_Z)), Quaternion.identity);
                _applyScoreViewBomb = bomb.AddComponent<ApplyScoreView>();
                _applyScoreViewBomb.SetScore(-5);
                _applyScoreViewBomb.Initialize(_touchViewModel);
            }
            
            Invoke("StartSpawning",0.5f);
        }

        
    }
}