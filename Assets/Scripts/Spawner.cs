using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private float startSpawntime = 2f;
    [SerializeField]
    private float endSpawnTime = 4f;
    [SerializeField]
    private GameObject[] spawnList;

    private float time = 0f;
    private float spawnTime = 0f;

    private void Start()
    {
        spawnTime = Random.Range(startSpawntime, endSpawnTime);
    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            // Spawn
            GameObject spawnPrefab = spawnList[Random.Range(0, spawnList.Length)];
            Instantiate(spawnPrefab, transform.position, transform.rotation, transform);

            time = 0f;
            spawnTime = Random.Range(startSpawntime, endSpawnTime);
        }
    }
}
