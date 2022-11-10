using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    private float time;
    private GameObject wall;

    [SerializeField] private float maxTime;
    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;
    [SerializeField] private GameObject wallPrefab;
    [SerializeField] private ObjectPooler wallPool;

    private void Start()
    {
        time = maxTime;
    }

    void Update()
    {
        SpawnWall();
    }

    private void SpawnWall()
    {
        if (time <= 0)
        {
            wall = wallPool.GetPooledObject();
            wall.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            wall.SetActive(true);
            time = maxTime;
        }

        time -= Time.deltaTime;
    }
}
