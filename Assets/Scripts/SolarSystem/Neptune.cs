using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neptune : MonoBehaviour
{
    Collider nCollider;


    void Start()
    {
        nCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tNeptunePedestal"))
        {
            nCollider.enabled = !nCollider.enabled;
            //Debug.Log("Collider.enabled = " + nCollider.enabled);


        }
        else
        {

            nCollider.enabled = nCollider.enabled;
        }


    }
}
