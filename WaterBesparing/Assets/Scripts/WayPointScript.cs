using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour
{
    void Start()
    {
        PlayerScript AI = FindObjectOfType<PlayerScript>();
        AI.waypoints.Add(gameObject);
    }

}
