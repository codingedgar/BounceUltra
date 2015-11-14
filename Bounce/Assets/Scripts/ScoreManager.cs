using UnityEngine;

public class ScoreManager
{
    #region Variables
    public const string UpdateScoreMsg = "UpdateScoreMsg";
    public const string UpdateScoreAccumulatorMsg = "UpdateScoreAccumulatorMsg";
    public int totalScore = 0;
    #endregion

    #region Methods
    public void UpdateScoreAccumulator(int value)
    {
        totalScore += value;
        Messenger.Broadcast<int>(UpdateScoreMsg, totalScore);
    }



    #endregion
}
