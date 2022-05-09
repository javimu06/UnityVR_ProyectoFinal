using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField]
    Animator[] anim1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("MiVieja");
            for(int i = 0; i < anim1.Length; i++)
            {
                anim1[i].SetTrigger("reggaeton");
            }
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < anim1.Length; i++)
            {
                anim1[i].SetTrigger("hiphop");
            }
        }
        else if (Input.GetKeyDown(KeyCode.J))
        {
            for (int i = 0; i < anim1.Length; i++)
            {
                anim1[i].SetTrigger("nanoBaile");
            }
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            for (int i = 0; i < anim1.Length; i++)
            {
                anim1[i].SetTrigger("gangnam");
            }
        }
    }
}
