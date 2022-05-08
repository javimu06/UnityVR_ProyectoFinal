using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem.Sample;
public class CauldronBehaviour : MonoBehaviour
{
    [SerializeField]
    GameObject EfectoRojo;
    [SerializeField]
    GameObject EfectoMorado;
    [SerializeField]
    GameObject EfectoAzul;
    [SerializeField]
    GameObject Agua;



    public string lastColor;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Grenade>())
        {
            switch (other.GetComponent<PotionInfo>().name)
            {
                case "Naranja":
                    EfectoRojo.GetComponent<ParticleSystem>().Play();
                    //Agua.GetComponent<Material>().SetColor("Color", Color.red);
                   // Agua.GetComponent<Material>().SetColor("TopColor", Color.red);
                    break;
                case "Azul":
                    EfectoAzul.GetComponent<ParticleSystem>().Play();
                   // Agua.GetComponent<Material>().SetColor("Color", Color.blue);
                    //Agua.GetComponent<Material>().SetColor("TopColor", Color.blue);
                    break;
                case "Morado":
                    EfectoMorado.GetComponent<ParticleSystem>().Play();
                   // Agua.GetComponent<Material>().SetColor("Color", Color.magenta);
                   // Agua.GetComponent<Material>().SetColor("TopColor", Color.magenta);
                    break;
            }
            lastColor = other.GetComponent<PotionInfo>().name;
        }

        if (other.GetComponent<Gun>())
        {
            switch (lastColor)
            {
                case "Naranja":
                    other.transform.GetChild(0).GetComponent<MeshRenderer>().material = other.GetComponent<WandInfo>().VaritaNaranja;
                    other.GetComponent<Gun>().bullet = other.GetComponent<WandInfo>().RedBullet;
                    break;
                case "Morado":
                    other.transform.GetChild(0).GetComponent<MeshRenderer>().material = other.GetComponent<WandInfo>().VaritaMorada;
                    other.GetComponent<Gun>().bullet = other.GetComponent<WandInfo>().PurpleBullet;
                    break;
                case "Azul":
                    other.transform.GetChild(0).GetComponent<MeshRenderer>().material = other.GetComponent<WandInfo>().VaritaAzul;
                    other.GetComponent<Gun>().bullet = other.GetComponent<WandInfo>().BlueBullet;
                    break;
            }
        }
    }
}
