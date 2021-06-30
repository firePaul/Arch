using System;

namespace MVVM
{
    public interface ITouchViewModel
    {
        ITouchModel TouchModel { get; }
        void ApplyScore(int score);
        event Action<int> OnScoreChanged;
    }
}