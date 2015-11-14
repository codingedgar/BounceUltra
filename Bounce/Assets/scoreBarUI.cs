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
        Messenger.AddListener<int>(ScoreManager.UpdateScoreMsg, UpdateEventHandler);
    }


    void UpdateEventHandler(int value)
    {



    }

}
