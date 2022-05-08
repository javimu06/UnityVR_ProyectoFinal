using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillZone : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.name);
        //Si metes el cubo dentro de la zona...
        if (other.GetComponent<GlassFill>() != null)
        {
            //Se rellena
            other.GetComponent<GlassFill>().fillBottle();
        }
    }
    private void OnEnable()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
    private void OnDisable()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
}
