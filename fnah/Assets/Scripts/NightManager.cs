using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightManager : MonoBehaviour
{
    public static int night = 1;

    public static void nextNight()
    {
        if (night < 5)
        {
            night++;
        }
        else
        {
            //win the game
        }
    }
}
