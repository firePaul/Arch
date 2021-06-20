﻿using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    internal sealed class PanelTwo : BaseUI
    {
        [SerializeField] private TMP_Text _text;
        
        public override void Execute()
        {
            _text.text = nameof(PanelTwo);
            gameObject.SetActive(true);
        }

        public override void Cancel()
        {
            gameObject.SetActive(false);
        }
    }

}