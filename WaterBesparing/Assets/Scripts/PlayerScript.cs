using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> waypoints;
    public GameObject KitchenBlock;
    public int Destination = 0;
    public LayerMask touchInputMask;


    public float minDist;
    public float speed;

    public bool active = true;

    void Update()
    {

        if (Input.touchCount > 0)
        {
            foreach (Touch touch in Input.touches)
            {
                Ray ray = GetComponent<Camera>().ScreenPointToRay(touch.position);
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


        float dist = Vector3.Distance(gameObject.transform.position, waypoints[Destination].transform.position);

        if (active)
        {
            if (dist > minDist)
            {
                Move();
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    Destination = 0;
                    //LivingRoom
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    Destination = 1;
                    //Kitchen
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    Destination = 2;
                    //BedroomAdult
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    Destination = 3;
                    //BedroomChild
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    Destination = 4;
                    //Bathroom
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    Destination = 5;
                    //Toilet
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    Destination = 6;
                    //Garden
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8))
                {
                    Destination = 7;
                    //Garage
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
