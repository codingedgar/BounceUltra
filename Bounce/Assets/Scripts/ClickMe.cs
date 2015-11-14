using UnityEngine;
using System.Collections;

public class ClickMe : MonoBehaviour
{

    #region Variables
    int scoreToGiveAtClick = 1;
    GameObject target = null;
    #endregion

    #region Methods

    public void Start()
    {
        target = this.gameObject.GetComponentInParent<SphereSetUp>().gameObject;
    }
    
    void OnMouseDown()
    {

        GameManager.Instance.scoreManager.UpdateScoreAccumulator(scoreToGiveAtClick);

        Destroy();
    }

    public void Destroy()
    {
        this.target.BroadcastMessage("Explode");
        Destroy(this.target);
    }
    #endregion
}
