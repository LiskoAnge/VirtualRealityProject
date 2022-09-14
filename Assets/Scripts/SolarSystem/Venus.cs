using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venus : MonoBehaviour
{
    Collider vCollider;


    void Start()
    {
        vCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tVenusPedestal"))
        {
            vCollider.enabled = !vCollider.enabled;
            //Debug.Log("Collider.enabled = " + vCollider.enabled);


        }
        else
        {

            vCollider.enabled = vCollider.enabled;
        }


    }
}
