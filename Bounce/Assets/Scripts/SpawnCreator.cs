using UnityEngine;
using System.Collections;

/// <summary>
/// Creates an game object
/// </summary>
public class SpawnCreator : MonoBehaviour {

	/// <summary>
	/// Object to be spawned
	/// </summary>
	public GameObject spawnedObject;

	/// <summary>
	/// Amount by wave
	/// </summary>
	public int waveAmountMin;

	/// <summary>
	/// Amount by wave
	/// </summary>
	public int waveAmountMax;

	/// <summary>
	/// limit of balls created
	/// </summary>
	public int limit;

	/// <summary>
	/// Time between waves
	/// </summary>
	public float betweenWavesTimeMin;

	/// <summary>
	/// Time between waves
	/// </summary>
	public float betweenWavesTimeMax;

	/// <summary>
	/// Minimal value for the force
	/// </summary>
	public float initialForceMin;

	/// <summary>
	/// Maximum value for the force
	/// </summary>
	public float initialForceMax;

	public bool isBigBallSpawner;

	/// <summary>
	/// Starts this instance
	/// </summary>
	void Start()
	{
		if(isBigBallSpawner)
			StartCoroutine(loop());
	}

	/// <summary>
	/// Main Loop
	/// </summary>
	/// <returns></returns>
	IEnumerator loop() {
		int i;
		int cont = 0;
		int waveAmount;
		while (cont < limit) {
			waveAmount = Random.Range(waveAmountMin, waveAmountMax);
			for (i = 0; i < waveAmount; i++) {
				Spawn();
            }
			cont += waveAmount;
			yield return new WaitForSeconds(Random.Range(betweenWavesTimeMin, betweenWavesTimeMax));
		}
	}

	public void SpawnWave() {
		int waveAmount = Random.Range(waveAmountMin, waveAmountMax);
		for (int i = 0; i < waveAmount; i++)
		{
			Spawn();
		}
	}

	/// <summary>
	/// Spawn the Object
	/// </summary>
	public void Spawn () {
		transform.position = new Vector3 (Random.Range(-0.1F, 0.1F), Random.Range(-0.1F, 0.1F), transform.position.z);
		GameObject reference = (GameObject)Instantiate(spawnedObject, transform.position, Quaternion.identity);
		reference.GetComponent<Rigidbody>().AddForce(Random.insideUnitSphere * Random.Range(initialForceMin,initialForceMax));

        reference.GetComponent<SphereSetUp>().Init();
	}
}
