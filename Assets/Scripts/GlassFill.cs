using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassFill : MonoBehaviour
{
    // Start is called before the first frame update
    Material mt;
    void Start()
    {
        mt = this.GetComponent<Material>();
    }

    // Update is called once per frame
    void Update()
    {
        mt.shader.pro.FindPropertyIndex("fill") += 0.1;
    }
}
