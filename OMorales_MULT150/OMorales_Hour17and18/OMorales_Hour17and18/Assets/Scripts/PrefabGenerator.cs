using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
   public GameObject prefab;
   public GameObject Lamp;
   public Vector3 spawnValues;

    void Start ()
    {

            for (int i=1; i<=10; i++)
             {
                Vector3 spawnposition = new Vector3 (Random.Range(-spawnValues.x, spawnValues.x), 1f, Random.Range(-spawnValues.z, spawnValues.z));
                GameObject gameObject = Instantiate<GameObject>(Lamp, new Vector3(2f,1f,5f), Quaternion.identity);
            }
       

    }   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
