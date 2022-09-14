using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JupiterPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Jupiter;
    public GameObject JupiterPanel;

    public Material[] materials;

    Renderer r;


    private void Start()
    {

        Jupiter.gameObject.SetActive(false);
        JupiterPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tJupiter"))
        {


            r.sharedMaterial = materials[1];

            Jupiter.gameObject.SetActive(true);
            JupiterPanel.gameObject.SetActive(true);



            rightPlace.Play();

        }
        else
        {
   
            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
