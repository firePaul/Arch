using System;
using TMPro;
using UnityEngine;

namespace Asteroids.Interpreter
{
    internal sealed class ScoreConverter : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_InputField _inputField;
        private long _score;
        
        private void Start()
        {
            _inputField.onValueChanged.AddListener(Interpret);
        }

        private void Interpret(string value)
        {
            if (Int64.TryParse(value, out var number))
            {
                _text.text = ConScore(number);
            }
        }

        private string ConScore(long score)
        {

            if (score / 1000 < 1) return $"{score}";
            if (score / 1000000000 >= 1) 
            {
                _score = score / 1000000000;
                if (score % 1000000000 > 500000000) _score += 1;
                return $"{_score}B";
            }
            if (score / 1000000 >= 1) 
            {
                _score = score / 1000000;
                if (score % 1000000 > 500000) _score += 1;
                return $"{_score}M";
            }
            if (score / 1000 >= 1) 
            {
                _score = score / 1000;
                if (score % 1000 > 500) _score += 1;
                return $"{_score}K";
            }
            return string.Empty;
            
            

        }
    }
}