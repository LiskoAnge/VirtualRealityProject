using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public Rigidbody rgbd;



    private void Start()
    {
        rgbd = GetComponent<Rigidbody>();
        rgbd.GetComponent<Rigidbody>().AddForce(new Vector3(1f, -1f, 2f), ForceMode.Impulse);
    }





    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag.Equals("tDestr"))
        {

            Destroy(gameObject);
            //Debug.Log("asteroid destroyed by invisible walls");


        }


    }





}
