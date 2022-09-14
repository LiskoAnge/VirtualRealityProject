using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaturnPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Saturn;
    public GameObject SaturnPanel;


    public Material[] materials;

    Renderer r;


    private void Start()
    {

        Saturn.gameObject.SetActive(false);
        SaturnPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tSaturn"))
        {


            r.sharedMaterial = materials[1];

            Saturn.gameObject.SetActive(true);
            SaturnPanel.gameObject.SetActive(true);



            rightPlace.Play();

        }
        else
        {

            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
