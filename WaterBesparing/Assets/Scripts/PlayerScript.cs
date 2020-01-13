using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum RoomPos
{
    BedroomEnum,
    BathroomEnum,
    KitchenEnum,
    Outside,
    Garage
}

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> waypoints;
    public int Destination = 0;
    public LayerMask touchInputMask;

    RoomPos Movement = RoomPos.BedroomEnum;

    public bool active = true;

    public GameObject TestPoint;

    public NavMeshAgent agent;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

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

        switch (Movement)
        {
            case RoomPos.BedroomEnum:
                if (Input.GetKeyDown(KeyCode.H))
                {
                    agent.destination = waypoints[1].transform.position;
                    Movement = RoomPos.BathroomEnum;
                }
                break;
            case RoomPos.BathroomEnum:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    agent.destination = waypoints[2].transform.position;
                    Movement = RoomPos.BathroomEnum;
                }
                break;
            case RoomPos.KitchenEnum:
                if (Input.GetKeyDown(KeyCode.A))
                {

                }
                break;
            case RoomPos.Outside:
                if (Input.GetKeyDown(KeyCode.A))
                {

                }
                break;
            case RoomPos.Garage:
                if (Input.GetKeyDown(KeyCode.A))
                {

                }
                break;
        }

    }
}

