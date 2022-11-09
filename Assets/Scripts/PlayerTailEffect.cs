using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTailEffect : MonoBehaviour
{
    [SerializeField] private float startTimeBtwSpawn;
    [SerializeField] private float lifetimeSpawn;

    [SerializeField] private GameObject tailPrefab;
    [SerializeField] private ObjectPooler tilePool;

    private Player player;
    private float timeBtwSpawn;

    private void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        if (!player.IsGrounded)
        {
            StartCoroutine(StartEffect());
        }
    }

    IEnumerator StartEffect()
    {
        if (timeBtwSpawn > 0)
        {
            timeBtwSpawn -= Time.deltaTime;
        }
        else
        {
            timeBtwSpawn = startTimeBtwSpawn;
            // GameObject tail = Instantiate(tailPrefab, transform.position, Quaternion.identity);
            
            GameObject tail = tilePool.GetPooledObject();
            
            if (tail != null)
            {
                tail.transform.position = transform.position;
                tail.SetActive(true);

                yield return new WaitForSeconds(lifetimeSpawn);
                tail.SetActive(false);
            }
            
            // Destroy(tail, lifetimeSpawn);
        }
    }
}
