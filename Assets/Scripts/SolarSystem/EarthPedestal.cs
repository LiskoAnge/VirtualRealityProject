using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthPedestal : MonoBehaviour
{

    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Earth;
    public GameObject EarthPanel;

    public Material[] materials;

    Renderer r;




    private void Start()
    {
        Earth.gameObject.SetActive(false);
        EarthPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];


    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tEarth"))
        {



            r.sharedMaterial = materials[1];

            Earth.gameObject.SetActive(true);
            EarthPanel.gameObject.SetActive(true);

            rightPlace.Play();

        }
        else
        {

            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }



}
