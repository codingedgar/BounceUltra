using UnityEngine;
using System.Collections;

public class SphereSetUp : MonoBehaviour {

    

    #region Variables

    public ClickMe clickMe = null;
    public SpheareIdentifier identifier = null;
    public MeshRenderer renderer = null;
    #endregion

    #region Methods
    
    public void Init()
    {
        this.renderer = GetComponent<MeshRenderer>();
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
        this.identifier.InitWithRandom(this);
    }

    #endregion
}
