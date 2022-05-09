using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoyDardo : MonoBehaviour
{
    Rigidbody rb;
    Vector3 pos;

    private void Start()
    {
        pos = GetComponent<Transform>().position;
        rb = GetComponent<Rigidbody>();

    }
    public void freeze()
    {
        rb.isKinematic = true;
        rb.detectCollisions = false;
    }
    public void stopFreeze()
    {
        rb.isKinematic = false;
        rb.detectCollisions = true;
        transform.position = pos;
    }
}
