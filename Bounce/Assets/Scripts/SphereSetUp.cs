using UnityEngine;
using System.Collections;

public class SphereSetUp : MonoBehaviour {

    

    #region Variables

    ClickMe clickMe = null;
    SpheareIdentifier identifier = null;
    #endregion

    #region Methods
    
    public void Init()
    {
        addComponents();
        InitComponentes();
    }
    
    void addComponents()
    {
        
        this.clickMe = this.gameObject.GetComponentInChildren<ClickArea>().gameObject.AddComponent<ClickMe>();

        this.identifier = this.gameObject.AddComponent<SpheareIdentifier>();
    }

    void InitComponentes()
    {
        this.identifier.RamdomType();
    }

    #endregion
}
