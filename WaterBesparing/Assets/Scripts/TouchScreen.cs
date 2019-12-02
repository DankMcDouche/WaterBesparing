using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    public PlayerScript player;


    void OnTouchDown()
    {
        player.Destination = 1;
        print("I got TOOCHED");
    }
}
