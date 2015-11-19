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
       /* Prueba de empuja hacia una direccion
       Vector3 dir = new Vector3(0f, 500f, 0f);
        dir.Normalize();
        this.gameObject.GetComponent<Rigidbody>().AddForce(dir * 300);
        */
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
