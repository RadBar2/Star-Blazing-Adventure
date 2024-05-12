using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static bool stop;
    Vector3 position;

    public List<GameObject> obstacles;

    public float spawnRate = 1;

    public GameObject Portal;
    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 0, spawnRate);
    }

    void SpawnObstacle()
    {
        if (stop) return;

        var index = Random.Range(0, obstacles.Count);
        var prefab = obstacles[index];

        position = transform.position;
        position.y = Random.Range(-5, 5);
        if (Portal.activeSelf) position.x = 7;

        Instantiate(prefab, position, transform.rotation);
    }
}
