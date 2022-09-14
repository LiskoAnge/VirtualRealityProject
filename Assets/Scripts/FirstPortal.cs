using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstPortal : MonoBehaviour
{




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("tPlayer"))
        {


            SceneManager.LoadScene(1);



        }


    }


}
