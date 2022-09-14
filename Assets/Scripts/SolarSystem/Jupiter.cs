using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jupiter : MonoBehaviour
{
    Collider jCollider;


    void Start()
    {
        jCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tJupiterPedestal"))
        {
            jCollider.enabled = !jCollider.enabled;
            //Debug.Log("Collider.enabled = " + jCollider.enabled);


        }
        else
        {

            jCollider.enabled = jCollider.enabled;
        }


    }
}
