using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour {

    #region Variables
    public int playerNumber;
    Image mySprite = null;
    Text text = null;
    #endregion

    #region Methods
    void Start()
    {
        mySprite = this.gameObject.GetComponent<Image>();
        text = this.gameObject.GetComponentInChildren<Text>();
    }

    public void Init(PlayerSetUp player, SpheareType type)
    {
        mySprite.overrideSprite = type.ToSprite();

        this.text.text = (player.isMe) ? "ME" : "";
        
    }

    #endregion

}
