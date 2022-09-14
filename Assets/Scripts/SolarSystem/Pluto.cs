using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour
{
    Collider pCollider;


    void Start()
    {
        pCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tPlutoPedestal"))
        {
            pCollider.enabled = !pCollider.enabled;
            //Debug.Log("Collider.enabled = " + pCollider.enabled);


        }
        else
        {

            pCollider.enabled = pCollider.enabled;
        }


    }
}
