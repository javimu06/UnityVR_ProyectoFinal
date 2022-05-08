using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillZone : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        //Si metes el cubo dentro de la zona...
        if (other.GetComponent<GlassFill>() != null)
            //Se rellena
            other.GetComponent<GlassFill>().fillBottle();
    }
}
