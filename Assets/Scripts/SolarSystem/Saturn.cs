using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saturn : MonoBehaviour
{
    Collider sCollider;


    void Start()
    {
        sCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tSaturnPedestal"))
        {
            sCollider.enabled = !sCollider.enabled;
            //Debug.Log("Collider.enabled = " + sCollider.enabled);


        }
        else
        {

            sCollider.enabled = sCollider.enabled;
        }


    }
}
