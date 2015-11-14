using UnityEngine;
using System.Collections;

public class PlayerSetUp : MonoBehaviour {

    public bool isMe;
    public int playerNumber;

    public SpheareType myType;
    
    public void Init()
    {
        this.myType = SpheareType.Red;
    }

}
