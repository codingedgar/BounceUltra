using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class scoreBarUI : MonoBehaviour
{

    #region Variables
    public bool enemy;
    public bool friend;

    public Image myImage = null;
    #endregion

    #region Methods

    #endregion
    // Use this for initialization
    void Awake()
    {
        this.myImage = this.gameObject.GetComponent<Image>();
        this.myImage.fillAmount = 0.0f;

        if (this.friend)
            Messenger.AddListener<int>(ScoreManager.UpdateScoreMsg, UpdateEventHandler);

        if (this.enemy)
            Messenger.AddListener<int>(ScoreManager.UpdateScoreEnemyMsg, UpdateEventHandler);
    }
    
    void UpdateEventHandler(int value)
    {
        float ammount = 0.0f;

        ammount = (value / (float)GameManager.Instance.scoreManager.maxScore);
        
        this.myImage.fillAmount = ammount;

    }
}
