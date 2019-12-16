using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> waypoints;
    public int Destination = 0;
    public LayerMask touchInputMask;


    public float minDist;
    public float speed;
    public float dist;

    public bool active = true;

    void Update()
    {

        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit Hit;
                if (Physics.Raycast(ray, out Hit, touchInputMask))
                {
                    GameObject recipient = Hit.transform.gameObject;
                    if (touch.phase == TouchPhase.Began)
                    {
                        recipient.SendMessage("OnTouchDown", Hit.point, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }

        dist = Vector3.Distance(gameObject.transform.position, waypoints[Destination].transform.position);

        if (active)
        {

            if (dist < minDist)
            {
                // Hallway Upstairs
                if (Destination == 1)
                {
                    Destination = 2;
                }
                else if (Destination == 2)
                {
                    Destination = 3;
                }
                else if (Destination == 3)
                {
                    Destination = 4;
                }
                //stairs
                if (Destination == 5)
                {
                    Destination = 6;
                }
                else if (Destination == 6)
                {
                    Destination = 7;
                }
                else if (Destination == 7)
                {
                    Destination = 8;
                }
                else if (Destination == 8)
                {
                    Destination = 9;
                }
                else if (Destination == 9)
                {
                    Destination = 10;
                }
                else if (Destination == 10)
                {
                    Destination = 11;
                }

            }

            if (dist > minDist)
            {
                Move();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    Destination++;
                }
            }
        }
    }

    private void Move()
    {
        gameObject.transform.LookAt(waypoints[Destination].transform.position);
        gameObject.transform.position += gameObject.transform.forward * speed * Time.deltaTime;
    }
}
