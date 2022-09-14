using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercury : MonoBehaviour
{


    Collider mCollider;


    void Start()
    {
        mCollider = GetComponent<Collider>();
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tMercuryPedestal"))
        {
            mCollider.enabled = !mCollider.enabled;
            //Debug.Log("Collider.enabled = " + mCollider.enabled);


        }
        else
        {

            mCollider.enabled = mCollider.enabled;
        }
       

    }
}
