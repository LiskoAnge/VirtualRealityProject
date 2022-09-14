using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarsPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;

    public GameObject Mars;
    public GameObject MarsPanel;

    public Material[] materials;

    Renderer r;


    private void Start()
    {
        Mars.gameObject.SetActive(false);
        MarsPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tMars"))
        {


            r.sharedMaterial = materials[1];

            Mars.gameObject.SetActive(true);
            MarsPanel.gameObject.SetActive(true);





            rightPlace.Play();

        }
        else
        {

            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
