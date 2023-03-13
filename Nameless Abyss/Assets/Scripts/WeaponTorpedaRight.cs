using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTorpedaRight : MonoBehaviour
{
    public float speed = 8f;
    

    void Update () 
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        // Vector3.в какое направление двигаться объекту
    }
}
