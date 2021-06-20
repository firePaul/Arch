using System;
using Asteroids;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    internal sealed class PanelOne : BaseUI
    {
        [SerializeField] private TMP_Text _text;
        [SerializeField] private TMP_Text _hp;
        [SerializeField] private TMP_Text _speed;
        [SerializeField] private Player _player;
        

        public override void Execute()
        {
            _text.text = nameof(PanelOne);
            _hp.text = _player._hp.ToString();
            _speed.text = _player._speed.ToString();
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }
}