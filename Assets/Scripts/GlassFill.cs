using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFill : MonoBehaviour
{
    Material mt;
    float amount = 0.5f;
    int fillID;
    void Start()
    {
        mt = GetComponent<MeshRenderer>().material;
        //Guardamos el ID del Fill para no llamarlo todo el rato
        fillID = Shader.PropertyToID("_Fill");
    }

    void Update()
    {
        mt.SetFloat(fillID, amount);
    }
    public void fillBottle()
    {
        amount += 0.005f;
        if (amount >= 1)
            amount = 1;
    }
}
