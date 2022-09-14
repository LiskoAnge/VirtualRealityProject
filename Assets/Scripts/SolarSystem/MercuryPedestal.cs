using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercuryPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Mercury;

    public GameObject MercuryPanel;

    public Material[] materials;

    Renderer r;




    private void Start()
    {

        Mercury.gameObject.SetActive(false);
        MercuryPanel.gameObject.SetActive(false);

        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tMercury"))
        {

            r.sharedMaterial = materials[1];
            Mercury.gameObject.SetActive(true);
            MercuryPanel.gameObject.SetActive(true);

            rightPlace.Play();

        }
        else
        {
    
            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
