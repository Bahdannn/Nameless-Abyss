using UnityEngine;

public class BombSpawn : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject spawnObject;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(spawnObject, spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
