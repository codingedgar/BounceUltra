using UnityEngine;
using System.Collections;

public class ClickMe : MonoBehaviour
{

    #region Variables
    int scoreToGiveAtClick = 1;
    GameObject target = null;
    SphereSetUp setup;
    #endregion

    #region Methods

    public void Start()
    {
        setup = this.gameObject.GetComponentInParent<SphereSetUp>();

        target = setup.gameObject;
    }
    
    void OnMouseDown()
    {

        GameManager.Instance.scoreManager.UpdateScoreAccumulator(this.setup, scoreToGiveAtClick);

        Destroy();
    }

    public void Destroy()
    {
        this.target.BroadcastMessage("Explode");
        Destroy(this.target);
    }
    #endregion
}
