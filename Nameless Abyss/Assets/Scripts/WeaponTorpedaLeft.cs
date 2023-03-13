using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTorpedaLeft : MonoBehaviour
{
    public float speed = 8f;
    

    void Update () 
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        // Vector3.в какое направление двигаться объекту
    }
}
