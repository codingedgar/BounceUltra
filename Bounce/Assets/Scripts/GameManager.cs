using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    #region Variables
 

    public static GameManager Instance;

    public ScoreManager scoreManager = null;
    #endregion


    #region Methods

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Init();
    }

    void Init()
    {
        this.scoreManager = new ScoreManager();
    }

    #endregion

}
