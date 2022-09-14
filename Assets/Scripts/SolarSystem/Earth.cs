using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    Collider eCollider;


    void Start()
    {
        eCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tEarthPedestal"))
        {
            eCollider.enabled = !eCollider.enabled;
            //Debug.Log("Collider.enabled = " + eCollider.enabled);


        }
        else
        {

            eCollider.enabled = eCollider.enabled;
        }


    }
}
