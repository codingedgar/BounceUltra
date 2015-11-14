using UnityEngine;

public class ScoreManager
{

    #region Variables
    public const string UpdateScoreMsg = "UpdateScoreMsg";
    public const string UpdateScoreAccumulatorMsg = "UpdateScoreAccumulatorMsg";

    #region Enemy
    public const string UpdateScoreAllyMsg = "UpdateScoreAllyMsg";
    public const string UpdateScoreAccumulatorAllyMsg = "UpdateScoreAccumulatorAllyMsg";

    #endregion

    #region Ally
    public const string UpdateScoreEnemyMsg = "UpdateScoreEnemyMsg";
    public const string UpdateScoreAccumulatorEnemyMsg = "UpdateScoreAccumulatorEnemyMsg";
    #endregion

    public int totalScore = 0;

    public int totalScoreEnemy = 0;
    public int totalScoreAlly = 0;

    public int maxScore = 10;
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

    public void UpdateEnemyScore()
    {
        totalScoreEnemy++;

        Messenger.Broadcast<int>(UpdateScoreEnemyMsg, totalScoreEnemy);

        if (totalScoreEnemy >= maxScore )
        {
            ChangeSceneTo.ChangeTo(scenesInGame.Start);
        }
    }

    #endregion
}
