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

    public RoomPos Movement;

    float dist;

    public Vector3 direction;

    public GameObject TestPoint;
    public UImanager UIMAN;
    public Rigidbody _Rigidbody;
    public NavMeshAgent agent;
    public Animator Anim;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Anim = GetComponent<Animator>();
        Movement = RoomPos.BedroomEnum;
    }

    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0f, (Input.GetAxis("Vertical")));
        direction.Normalize();

        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.SetBool("walking", true);
            print("if i pressa da b");
        }

        if (direction.magnitude <= 0.1)
        {
            Anim.SetBool("walking", false);
        }
        else 
        {
            Anim.SetBool("walking", true);
        }

        // this is touching gameobjects (Input)

        //if (Input.touchCount > 0)
        //{
        //    foreach (Touch touch in Input.touches)
        //    {
        //        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        //        RaycastHit Hit;
        //        if (Physics.Raycast(ray, out Hit, touchInputMask))
        //        {
        //            GameObject recipient = Hit.transform.gameObject;
        //            if (touch.phase == TouchPhase.Began)
        //            {
        //                recipient.SendMessage("OnTouchDown", Hit.point, SendMessageOptions.DontRequireReceiver);
        //            }
        //        }
        //    }
        //}

        switch (Movement)
        {
            case RoomPos.BedroomEnum:

                if (Input.GetKeyDown(KeyCode.A))
                {
                    agent.destination = waypoints[1].transform.position;
                    Movement = RoomPos.BathroomEnum;
                }
                break;
            case RoomPos.BathroomEnum:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    agent.destination = waypoints[2].transform.position;
                    Movement = RoomPos.KitchenEnum;
                }
                float dist = Vector3.Distance(waypoints[1].transform.position, transform.position);
                if (dist <= 2)
                {
                    
                }

                break;
            case RoomPos.KitchenEnum:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    agent.destination = waypoints[3].transform.position;
                    Movement = RoomPos.Garage;
                }
                dist = Vector3.Distance(waypoints[2].transform.position, transform.position);
                if (dist <= 2)
                {
                    UIMAN.AfwasActive = true;
                }
                break;
            case RoomPos.Outside:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    agent.destination = waypoints[0].transform.position;
                    Movement = RoomPos.BedroomEnum;
                }
                dist = Vector3.Distance(waypoints[4].transform.position, transform.position);
                if (dist <= 2)
                {
                    UIMAN.PlantenWaterenActive = true;
                }
                break;
            case RoomPos.Garage:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    agent.destination = waypoints[4].transform.position;
                    Movement = RoomPos.Outside;
                }
                dist = Vector3.Distance(waypoints[3].transform.position, transform.position);
                if (dist <= 2)
                {
                    //UIMAN.Active = true;
                }
                break;
        }

    }
}

