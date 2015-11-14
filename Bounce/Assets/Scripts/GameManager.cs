using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GameManager : MonoBehaviour
{

    #region Variables
    public static GameManager Instance;


    public PlayerSetUp[] players = null;
    public SpheareType myType = SpheareType.Red;

    public PlayerUI[] playerUIs = null;

    public scoreBarUI scoreBar = null;

    #region Score
    public ScoreManager scoreManager = null;

    [SerializeField]
    float EnemySpeed;

    #endregion
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
        getPlayersUIs();
        getRandomTypes();
        getMyType();
        
        StartCoroutine(Enemy());
    }

    

    IEnumerator Enemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(EnemySpeed);
            this.scoreManager.UpdateEnemyScore();
        }
    }

    void getMyType()
    {
        for (int i = players.Length - 1; i >= 0; i--)
        {
            if (this.players[i].isMe) this.myType = this.players[i].myType;
        }
    }

    void getPlayers()
    {
        this.players = this.gameObject.GetComponentsInChildren<PlayerSetUp>();

        for (int i = players.Length - 1; i >= 0; i--)
        {
            players[i].Init();
        }
    }


    void getPlayersUIs()
    {
        this.playerUIs = FindObjectsOfType<PlayerUI>();
        this.scoreBar = FindObjectOfType<scoreBarUI>();

    }

    void getRandomTypes()
    {
        List<SpheareType> listica = new List<SpheareType>();
        int r;

        listica = Enum.GetValues(typeof(SpheareType)).Cast<SpheareType>().ToList();

        for (int i = this.players.Length - 1; i >= 0; i--)
        {
            //set player type;
            r = UnityEngine.Random.Range(0, listica.Count);
            this.players[i].myType = listica[r];

            //check for match in ui;
            for (int o = this.playerUIs.Length - 1; o >= 0; o--)
            {
                if (this.playerUIs[o].playerNumber == this.players[i].playerNumber)
                {
                    setPlyerUIS(this.players[i], this.playerUIs[o]);
                }
            }

            listica.RemoveAt(r);
        }

    }

    void setPlyerUIS(PlayerSetUp player, PlayerUI colorUI)
    {
        colorUI.Init(player, player.myType);
        setImageBar(player.myType);
    }

    void setImageBar(SpheareType type) {

        this.scoreBar.Init(type);

    }


    #endregion

}
