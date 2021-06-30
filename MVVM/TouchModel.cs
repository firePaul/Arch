namespace MVVM
{
    public class TouchModel : ITouchModel
    {
        public int score { get; set; }

        public TouchModel(int startscore)
        {
            score = startscore;
        }
    }
}