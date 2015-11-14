using UnityEngine;
using System.Collections;

public class BigClickMe : ClickMe {

	#region Variables

	public float force;

	SpawnCreator spawnCreator;

	#endregion

	#region Methods

	new void Start() {
		base.Start();
		spawnCreator = transform.parent.GetComponentInChildren<SpawnCreator>();
	}

	protected override void OnMouseDown()
	{
		_rigidbody.AddForce(Vector3.forward * force);

        if (((BigSphereSetUp)setup).addToCounter())
			Destroy();
	}

	public new void Destroy()
	{
		spawnCreator.SpawnWave();
		base.Destroy();
	}
	#endregion
}
