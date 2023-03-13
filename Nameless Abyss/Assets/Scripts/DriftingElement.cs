using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriftingElement : MonoBehaviour
{
    public float speed = 4f;
    // С какой скоростью должен двигаться объект

    void Update () {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        // Vector3.в какое направление двигаться объекту
    }
}
