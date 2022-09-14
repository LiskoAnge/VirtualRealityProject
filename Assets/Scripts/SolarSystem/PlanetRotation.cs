using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{

    public float speedRotation = 0.3f;

    

    void Update()
    {


        transform.Rotate(0, -speedRotation, 0);
       
    }
}
