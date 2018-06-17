using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesManager : MonoBehaviour
{

    [SerializeField] private int _collectablesToSpawn = 5;
    public int TotalCollectablesAmount;
    public GameObject collectable;
    [SerializeField] private float boundaries = 9f;
    [SerializeField] private float yOffset = .5f;

    void Start()
    {
        for (int i = 0; i < _collectablesToSpawn; i++)
        {
            SpawnCollectable();
        }
    }


    void SpawnCollectable()
    {

        Vector3 randomPosition = new Vector3();

        float randomX = Random.Range(-boundaries, boundaries);
        float randomZ = Random.Range(-boundaries, boundaries);

        randomPosition.x = randomX;
        randomPosition.y = yOffset;
        randomPosition.z = randomZ;
        Instantiate(collectable, randomPosition, Quaternion.identity);
        TotalCollectablesAmount++;
    }
}
