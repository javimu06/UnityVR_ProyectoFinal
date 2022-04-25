using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleFill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.up), 10);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.up), Color.red);

        
        //if ((targetForward.x >= 90 && targetForward.x <= 270) || (targetForward.z >= 90 && targetForward.x <= 270))
        //    transform.GetChild(0).gameObject.SetActive(true);
        //else
        //    transform.GetChild(0).gameObject.SetActive(false);
    }
}
