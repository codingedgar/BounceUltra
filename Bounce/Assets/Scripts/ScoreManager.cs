using UnityEngine;

public class ScoreManager
{
    #region Variables
    public const string UpdateScoreMsg = "UpdateScoreMsg";
    public const string UpdateScoreAccumulatorMsg = "UpdateScoreAccumulatorMsg";
    public int totalScore = 0;
    #endregion

    #region Methods
    public void UpdateScoreAccumulator(SphereSetUp type, int value)
    {
        if (type.identifier.type == GameManager.Instance.myType)
        {
            totalScore += value;
            Messenger.Broadcast<int>(UpdateScoreMsg, totalScore);
        }
    }



    #endregion
}
