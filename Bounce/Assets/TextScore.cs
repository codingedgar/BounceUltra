using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Text))]
public class TextScore : MonoBehaviour
{

    #region Variables
    
    Text text = null;
        
    #endregion

    #region Methods

    void Awake()
    {

    }

    void Start()
    {
        text = GetComponent<Text>();

        Messenger.AddListener<int>(GameManager.UpdateScoreMsg, updateScoreEventHandler);
    }

    void updateScoreEventHandler(int value)
    {
        text.text = value.ToString();
    }
    
    #endregion
}
