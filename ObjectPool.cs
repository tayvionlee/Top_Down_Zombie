using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;

    private List<GameObject> pooledObjects = new List<GameObject>();
    private int amountToPool;

    // reference to GameObject we want to pool
    [SerializeField] private GameObject bulletPrefab;


    private void Awake() 
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    
    void Start()
    {
        for (int i = 0; i < amountToPool; i++)
        {
            // instantiate the object you want to pool
            GameObject obj = Instantiate(bulletPrefab);

            // disable game object
            obj.SetActive(false);

            // add to the list of pooled objects
            pooledObjects.Add(obj);
        }
    }

    // public method that returns a game object
    public GameObject GetPooledObject()
    {
        // NOTE if you want to convert types to different things, add a method that
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
