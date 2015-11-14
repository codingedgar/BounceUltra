using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreTextUI : MonoBehaviour
{

    #region Variables
    public bool enemy;
    public bool friend;

    public Text myText = null;
    #endregion

    #region Methods

    #endregion
    // Use this for initialization
    void Awake()
    {
        this.myText = this.gameObject.GetComponent<Text>();
        
    }
    
    void Start()
    {
        if (this.friend)
            Messenger.AddListener<int>(ScoreManager.UpdateScoreMsg, UpdateEventHandler);

        if (this.enemy)
            Messenger.AddListener<int>(ScoreManager.UpdateScoreEnemyMsg, UpdateEventHandler);

    }

    void UpdateEventHandler(int value)
    {

        this.myText.text = value.ToString();

    }
}
