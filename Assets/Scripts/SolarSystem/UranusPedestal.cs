using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UranusPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Uranus;
    public GameObject UranusPanel;


    public Material[] materials;

    Renderer r;


    private void Start()
    {
        Uranus.gameObject.SetActive(false);
        UranusPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tUranus"))
        {


            r.sharedMaterial = materials[1];

            Uranus.gameObject.SetActive(true);
            UranusPanel.gameObject.SetActive(true);





            rightPlace.Play();

        }
        else
        {

            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
