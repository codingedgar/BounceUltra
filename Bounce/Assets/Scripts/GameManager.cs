using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    #region Variables
    

    public static GameManager Instance;

    public ScoreManager scoreManager = null;

    public PlayerSetUp[] players = null;
    public SpheareType myType = SpheareType.Red;
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

        getPlayers();
    }

    void getPlayers()
    {
        this.players = this.gameObject.GetComponentsInChildren<PlayerSetUp>();

        for (int i = players.Length - 1; i >= 0; i--)
        {
            players[i].Init();
        }
    }

    #endregion

}
