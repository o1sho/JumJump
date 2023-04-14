using UnityEngine;

public class AddScorePlayer : MonoBehaviour
{
    public void AddScore()
    {
        ScoreController.ScoreUp();
    }

    public void AddScore2x()
    {
        ScoreController.ScoreSuperUp();
    }
}
