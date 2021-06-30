using UnityEngine;
using UnityEngine.Serialization;

namespace MVVM
{
    public class SnakeStart : MonoBehaviour
    {
        [SerializeField] private TouchView _touchView;
        [SerializeField] private ApplyScoreView _applyScoreViewFruit;
        [SerializeField] private ApplyScoreView _applyScoreViewBomb;
        [SerializeField] private ApplyScoreView _applyScoreViewTail;
        private void Awake()
        {
            var Touchmodel = new TouchModel(0);
            var Touchviewmodel = new TouchViewModel(Touchmodel);
            _touchView.Initialize(Touchviewmodel);
            _applyScoreViewFruit.Initialize(Touchviewmodel);
            _applyScoreViewBomb.Initialize(Touchviewmodel);
            _applyScoreViewTail.Initialize(Touchviewmodel);
            
        }
    }
}