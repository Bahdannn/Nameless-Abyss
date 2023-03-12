using UnityEngine;

public class WeaponBomb : MonoBehaviour
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
