using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlutoPedestal : MonoBehaviour
{
    public AudioSource rightPlace;
    public AudioSource wrongPlace;



    public GameObject Pluto;
    public GameObject PlutoPanel;


    public Material[] materials;

    Renderer r;


    private void Start()
    {
        Pluto.gameObject.SetActive(false);
        PlutoPanel.gameObject.SetActive(false);
        r = GetComponent<Renderer>();
        r.enabled = true;
        r.sharedMaterial = materials[0];

    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tPluto"))
        {


            r.sharedMaterial = materials[1];

            Pluto.gameObject.SetActive(true);
            PlutoPanel.gameObject.SetActive(true);



            rightPlace.Play();

        }
        else
        {
   
            r.sharedMaterial = materials[0];
            wrongPlace.Play();
        }

    }

}
