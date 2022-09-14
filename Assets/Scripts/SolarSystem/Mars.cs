using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mars : MonoBehaviour
{
    Collider maCollider;


    void Start()
    {
        maCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tMarsPedestal"))
        {
            maCollider.enabled = !maCollider.enabled;
            //Debug.Log("Collider.enabled = " + maCollider.enabled);


        }
        else
        {

            maCollider.enabled = maCollider.enabled;
        }


    }
}
