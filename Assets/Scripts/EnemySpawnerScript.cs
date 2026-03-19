using UnityEngine;
using UnityEngine.Identifiers;

public class EnemySpawnerScript : MonoBehaviour
{

    public GameObject fallingObjectPrefab;

    void Start()
    {
        InvokeRepeating("SpawnFallingObject", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
     
        float randomX = Random.Range(-8f, 8f);

        Vector3 spawnPos = new Vector3(randomX, 6f, 0f);

        Instantiate(fallingObjectPrefab, spawnPos, Quaternion.identity);
    }
}
