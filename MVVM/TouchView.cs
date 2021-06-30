using System;
using TMPro;
using UnityEngine;

namespace MVVM
{
    public class TouchView : MonoBehaviour
    {
        private ITouchViewModel _touchViewModel;
        
        private TMP_Text score_Text;
        
        public void Initialize(ITouchViewModel touchViewModel)
        {
            score_Text = GameObject.Find("Score").GetComponent<TMP_Text>();
            _touchViewModel = touchViewModel;
            _touchViewModel.OnScoreChanged += OnScoreChanged;
            OnScoreChanged(_touchViewModel.TouchModel.score);
        }

        private void OnScoreChanged(int score)
        {
            score_Text.text = $"Score : {_touchViewModel.TouchModel.score}";
            
        }

        ~TouchView()
        {
            _touchViewModel.OnScoreChanged -= OnScoreChanged;
        }
    }
}