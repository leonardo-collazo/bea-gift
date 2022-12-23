using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    private float time;
    private GameObject food;

    [SerializeField] private float minTime;
    [SerializeField] private float maxTime;
    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;
    [SerializeField] private ObjectPooler foodPool;

    private void Start()
    {
        SetRandomTime();
    }

    void Update()
    {
        if (GameManager.Instance.IsGameActive)
        {
            SpawnFood();
        }
    }

    // Spawns a food after certain amount of time
    private void SpawnFood()
    {
        if (time <= 0)
        {
            food = foodPool.GetPooledObject();
            food.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            food.SetActive(true);

            SetRandomTime();
        }

        time -= Time.deltaTime;
    }

    // Sets a random value between minTime and maxSpawningTime values to time variable
    private void SetRandomTime()
    {
        time = Random.Range(minTime, maxTime);
    }
}
