using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    #region Variables

    #endregion
    public static GameManager Instance;

    #region Methods

    void Awake()
    {
        Instance = this;
    }

    #endregion

}
