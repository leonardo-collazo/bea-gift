using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject[] objectsToPool;
    public int amountToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Loop through list of pooled objects,deactivating them and adding them to the list 
        pooledObjects = new List<GameObject>();

        foreach (GameObject objectToPool in objectsToPool)
        {
            for (int i = 0; i < amountToPool; i++)
            {
                GameObject obj = Instantiate(objectToPool);
                obj.SetActive(false);
                pooledObjects.Add(obj);
                obj.transform.SetParent(transform); // set as children of Spawn Manager
            }
        }
    }

    public GameObject GetPooledObject()
    {
        int index = Random.Range(0, pooledObjects.Count);

        // Will search randomly in the list a pooled object
        while (true)
        {
            // if the pooled objects is NOT active, return that object 
            if (!pooledObjects[index].activeInHierarchy)
            {
                return pooledObjects[index];
            }
            else
            {
                index = Random.Range(0, pooledObjects.Count);
            }
        }
    }

}
