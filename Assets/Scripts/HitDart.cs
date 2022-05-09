using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDart : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<SoyDardo>())
            collision.gameObject.GetComponent<SoyDardo>().freeze();
    }
}
