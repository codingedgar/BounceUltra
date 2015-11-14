using UnityEngine;
using System.Collections;

public class SphereSetUp : MonoBehaviour {

    #region Variables
    ClickMe clickMe = null;
    #endregion

    #region Methods

    void Start()
    {
        addComponents();
    }

    void addComponents()
    {
        this.clickMe = this.gameObject.AddComponent<ClickMe>();
    }

    #endregion
}
