using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour
{
    public GameObject Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto;
    public static int planetBar;


    void Start()
    {
        planetBar = 9;

        Mercury.gameObject.SetActive(false);
        Venus.gameObject.SetActive(false);
        Earth.gameObject.SetActive(false);
        Mars.gameObject.SetActive(false);
        Jupiter.gameObject.SetActive(false);
        Saturn.gameObject.SetActive(false);
        Uranus.gameObject.SetActive(false);
        Neptune.gameObject.SetActive(false);
        Pluto.gameObject.SetActive(false);
    }

    void Update()
    {
        
        if (planetBar > 9)
            planetBar = 9;

        switch (planetBar)
        {
            case 9:

                Mercury.gameObject.SetActive(true);
                Venus.gameObject.SetActive(true);
                Earth.gameObject.SetActive(true);
                Mars.gameObject.SetActive(true);
                Jupiter.gameObject.SetActive(true);
                Saturn.gameObject.SetActive(true);
                Uranus.gameObject.SetActive(true);
                Neptune.gameObject.SetActive(true);
                Pluto.gameObject.SetActive(true);
                break;

            case 8:
                Mercury.gameObject.SetActive(true);
                Venus.gameObject.SetActive(true);
                Earth.gameObject.SetActive(true);
                Mars.gameObject.SetActive(true);
                Jupiter.gameObject.SetActive(true);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 7:
                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 6:
                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 5:
                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);

                break;
            case 4:
                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 3:

                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 2:
                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 1:

                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;

            case 0:

                Mercury.gameObject.SetActive(false);
                Venus.gameObject.SetActive(false);
                Earth.gameObject.SetActive(false);
                Mars.gameObject.SetActive(false);
                Jupiter.gameObject.SetActive(false);
                Saturn.gameObject.SetActive(false);
                Uranus.gameObject.SetActive(false);
                Neptune.gameObject.SetActive(false);
                Pluto.gameObject.SetActive(false);
                break;



        }





    }








}
