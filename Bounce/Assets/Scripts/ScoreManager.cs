using UnityEngine;

public class ScoreManager
{
    #region Variables
    public const string UpdateScoreMsg = "UpdateScoreMsg";
    public const string UpdateScoreAccumulatorMsg = "UpdateScoreAccumulatorMsg";
    public int totalScore = 0;

    public ScoreManagerView view = null;
    #endregion

    #region Methods

    public ScoreManager()
    {
        this.view = new ScoreManagerView();
    }

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
