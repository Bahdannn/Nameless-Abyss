using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedaSpawnRight : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnObject;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(spawnObject, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
