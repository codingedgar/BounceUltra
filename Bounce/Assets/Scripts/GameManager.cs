using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    #region Variables
    public const string UpdateScoreMsg = "UpdateScoreMsg";
    public const string UpdateScoreAccumulatorMsg = "UpdateScoreAccumulatorMsg";

    #endregion

    public static GameManager Instance;

    #region Methods

    void Awake()
    {
        Instance = this;
    }

    #endregion

}
