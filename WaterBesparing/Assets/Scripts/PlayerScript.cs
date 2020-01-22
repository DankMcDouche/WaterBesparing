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

    private bool shower;
    private bool toilet;
    private bool washingmachine;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();;
        Movement = RoomPos.BedroomEnum;
        shower = false;
        toilet = false;
        washingmachine = false;
    }

    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0f, (Input.GetAxis("Vertical")));
        direction.Normalize();

        if (Input.GetKeyDown(KeyCode.B))
        {
            Anim.SetBool("walking", true);
            //print("if i pressa da b");

            print(Anim.GetBool("walking"));
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
                    shower = true;
                }
                break;
            case RoomPos.BathroomEnum:

                if (shower == true)
                {
                    UIMAN.OpschonenActive = true;
                    dist = Vector3.Distance(waypoints[1].transform.position, transform.position);
                    if (dist <= 1 && UIMAN.OpschonenActive == false)
                    {
                        UIMAN.OpschonenActive = true;
                    }

                    if (UIMAN.OpschonenActive == false)
                    {
                        agent.destination = waypoints[2].transform.position;
                        shower = false;
                        toilet = true;
                    }
                }

                else if (toilet == true)
                {
                    dist = Vector3.Distance(waypoints[2].transform.position, transform.position);
                    if (dist <= 1)
                    {
                        UIMAN.ToiletActive = true;
                    }
                    else if (UIMAN.ToiletActive == false)
                    {
                        UIMAN.ToiletActive = false;
                        agent.destination = waypoints[3].transform.position;
                        toilet = false;
                        washingmachine = true;
                    }


                }
                else if (washingmachine == true)
                {
                    dist = Vector3.Distance(waypoints[3].transform.position, transform.position);
                    if (dist <= 1)
                    {
                        UIMAN.WasmachineActive = true;
                    }
                    else if (UIMAN.WasmachineActive == false)
                    {
                        UIMAN.WasmachineActive = false;
                        agent.destination = waypoints[4].transform.position;
                        Movement = RoomPos.KitchenEnum;
                        washingmachine = false;
                    }

                }

                break;
            case RoomPos.KitchenEnum:
                
                dist = Vector3.Distance(waypoints[4].transform.position, transform.position);
                if (dist <= 1)
                {
                    UIMAN.AfwasActive = true;
                }
                else if (UIMAN.AfwasActive == false)
                {
                    UIMAN.AfwasActive = false;
                    agent.destination = waypoints[5].transform.position;
                    Movement = RoomPos.Outside;
                }

                break;
            case RoomPos.Outside:
                
                dist = Vector3.Distance(waypoints[5].transform.position, transform.position);
                if (dist <= 1 && UIMAN.PlantenWaterenActive == false)
                {
                    UIMAN.PlantenWaterenActive = true;
                }
                else if (UIMAN.PlantenWaterenActive == false)
                {
                    UIMAN.PlantenWaterenActive = false;
                    agent.destination = waypoints[0].transform.position;
                    Movement = RoomPos.BedroomEnum;
                }
                break;
        }
    }
}

