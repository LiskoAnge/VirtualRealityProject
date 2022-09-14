using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VenusPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;


    public GameObject Venus;
    public GameObject VenusPanel;


    public Material[] materials;

    Renderer r;


    private void Start()
    {
        Venus.gameObject.SetActive(false);
        VenusPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tVenus"))
        {


            r.sharedMaterial = materials[1];


            Venus.gameObject.SetActive(true);
            VenusPanel.gameObject.SetActive(true);






            rightPlace.Play();

        }
        else
        {

            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }



}
