using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;

    public float spawnRate = 1.5f;
    public float spawnRangeX = 8f;
    public float safeZone = 2f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnMeteor), 1f, spawnRate);
    }

    void SpawnMeteor()
    {
        float randomX;

        do
        {
            randomX = Random.Range(-spawnRangeX, spawnRangeX);
        }
        while (Mathf.Abs(randomX) < safeZone);

        Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);

        Instantiate(meteorPrefab, spawnPos, Quaternion.identity);
    }
}