using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esnifada : MonoBehaviour
{

    public GameObject head;
    private AudioSource audi;
    // Start is called before the first frame update
    void Start()
    {
        audi = GetComponentInParent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == head)
        {
            Debug.Log("Esnifadota");
            audi.Play();
            gameObject.SetActive(false);
        }
    }
}
