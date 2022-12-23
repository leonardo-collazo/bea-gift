using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private float time;
    private float height;
    private GameObject obstacle;

    [SerializeField] private float minSpawningTime;
    [SerializeField] private float maxSpawningTime;
    [SerializeField] private ObjectPooler obstaclePool;

    private void Start()
    {
        SetSpawningTime();
    }

    void Update()
    {
        if (GameManager.Instance.IsGameActive)
        {
            SpawnObstacle();
        }
    }

    // Spawns a obstacle after certain amount of time
    private void SpawnObstacle()
    {
        if (time <= 0)
        {
            obstacle = obstaclePool.GetPooledObject();
            obstacle.SetActive(true);
            height = obstacle.GetComponent<InitialPosition>().StarterTransform.position.y;
            obstacle.transform.position = transform.position + new Vector3(0, height, 0);
            
            SetSpawningTime();
        }

        time -= Time.deltaTime;
    }

    private void SetSpawningTime()
    {
        time = Random.Range(minSpawningTime, maxSpawningTime);
    }
}
