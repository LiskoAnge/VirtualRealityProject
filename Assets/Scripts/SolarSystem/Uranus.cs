using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uranus : MonoBehaviour
{
    Collider uCollider;


    void Start()
    {
        uCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tUranusPedestal"))
        {
            uCollider.enabled = !uCollider.enabled;
            //Debug.Log("Collider.enabled = " + uCollider.enabled);


        }
        else
        {

            uCollider.enabled = uCollider.enabled;
        }


    }
}
