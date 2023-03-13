using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedaSrawnLeft : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(spawnObject, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
