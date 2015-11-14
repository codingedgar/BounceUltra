using UnityEngine;
using System.Collections;

public class BigSphereSetUp : SphereSetUp {

	#region Variables

	public int amountOfClicks;
	public float force = 700;
	//public float radius = 5.0F;
	//public float power = 10.0F;
	int playersCount;

	#endregion

	#region Methods

	void Start() {
		Init();
	}

    public override void Init()
    {
		this.renderer = GetComponent<MeshRenderer>();
		addComponents();
		//InitComponentes();
		playersCount = 0;
    }
    
    void addComponents()
    {
        this.clickMe = this.gameObject.GetComponentInChildren<ClickArea>().gameObject.AddComponent<BigClickMe>();
		((BigClickMe)this.clickMe).force = force;

        //this.identifier = this.gameObject.AddComponent<SpheareIdentifier>();
    }

	public bool addToCounter() {
		playersCount++;
		return playersCount >= amountOfClicks;
	}

    #endregion
}
