using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeptunePedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Neptune;
    public GameObject NeptunePanel;


    public Material[] materials;

    Renderer r;


    private void Start()
    {
        Neptune.gameObject.SetActive(false);
        NeptunePanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tNeptune"))
        {


            r.sharedMaterial = materials[1];

            Neptune.gameObject.SetActive(true);
            NeptunePanel.gameObject.SetActive(true);



            rightPlace.Play();

        }
        else
        {
            
            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
