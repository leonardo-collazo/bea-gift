using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    private float time;
    private GameObject coin;

    [SerializeField] private float maxTime;
    [SerializeField] private float maxHeight;
    [SerializeField] private float minHeight;
    [SerializeField] private GameObject coinPrefab;
    [SerializeField] private ObjectPooler coinPool;

    private void Start()
    {
        time = maxTime;
    }

    void Update()
    {
        SpawnCoin();
    }

    // Spawns a wall after certain amount of time
    private void SpawnCoin()
    {
        if (time <= 0)
        {
            coin = coinPool.GetPooledObject();
            coin.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            coin.SetActive(true);
            time = maxTime;
        }

        time -= Time.deltaTime;
    }
}
