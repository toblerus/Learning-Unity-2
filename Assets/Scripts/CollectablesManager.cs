using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesManager : MonoBehaviour {

	[SerializeField] private int _collectablesToSpawn = 5;
	public int TotalCollectablesAmount;
	public GameObject collectable;

	void Start () {
		for (int i = 0; i <= _collectablesToSpawn; i++) 
		{
			SpawnCollectable();
		}
	}
	

	void SpawnCollectable() {
		float boundaries = 9f;

		Vector3 randomPosition = new Vector3 ();

		float randomX = Random.Range (-boundaries, boundaries);
		float randomZ = Random.Range (-boundaries, boundaries);

		randomPosition.x = randomX;
		randomPosition.y = 0.5f; //How can I get the current height of the object i clone, so I don't have to enter it here?
		randomPosition.z = randomZ;
		Instantiate(collectable, randomPosition, Quaternion.identity);
		TotalCollectablesAmount++;
	}
}
