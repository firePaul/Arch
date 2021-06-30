using System;

namespace MVVM
{
    public class TouchViewModel : ITouchViewModel
    {
        public event Action<int> OnScoreChanged;
        public ITouchModel TouchModel { get; }

        public TouchViewModel(ITouchModel touchModel)
        {
            TouchModel = touchModel;
        }
        
        public void ApplyScore(int score)
        {
            TouchModel.score += score;
            OnScoreChanged?.Invoke(TouchModel.score);
        }

        
    }
}