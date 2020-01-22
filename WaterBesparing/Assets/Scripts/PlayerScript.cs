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
    public LayerMask touchInputMask;

    public List<GameObject> waypoints;
    public int Destination = 0;

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

    public bool NoShower;
    public bool NoToilet;
    public bool NoWash;
    public bool NoVaat;
    public bool NoPlant;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        Movement = RoomPos.BedroomEnum;
        shower = false;
        toilet = false;
        washingmachine = false;

        NoShower = false;
        NoToilet = false;
        NoWash = false;
        NoVaat = false;
        NoPlant = false;


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
        Moving();
    }

    public void Moving()
    {
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
                    dist = Vector3.Distance(waypoints[1].transform.position, transform.position);
                    if (dist <= 1)
                    {
                        if (NoShower == true)
                        {
                            agent.destination = waypoints[2].transform.position;
                            shower = false;
                            toilet = true;
                        }
                        else if (NoShower == false)
                        {
                            UIMAN.OpschonenActive = true;
                        }
                    }
                }

                if (toilet == true)
                {
                    dist = Vector3.Distance(waypoints[2].transform.position, transform.position);
                    if (dist <= 1)
                    {
                        
                        if (NoToilet == true)
                        {
                            agent.destination = waypoints[3].transform.position;
                            toilet = false;
                            washingmachine = true;
                        }
                        else if (NoToilet == false)
                        {
                            UIMAN.ToiletActive = true;
                        }
                    }
                }
                if (washingmachine == true)
                {
                    dist = Vector3.Distance(waypoints[3].transform.position, transform.position);
                    if (dist <= 1)
                    {
                        if (NoWash == true)
                        {
                            agent.destination = waypoints[4].transform.position;
                            Movement = RoomPos.KitchenEnum;
                            washingmachine = false;
                        }
                        else if (NoWash == false)
                        {
                            UIMAN.WasmachineActive = true;
                        }
                    }
                }

                break;
            case RoomPos.KitchenEnum:

                dist = Vector3.Distance(waypoints[4].transform.position, transform.position);
                if (dist <= 1)
                {
                    if (NoVaat == true)
                    {
                        agent.destination = waypoints[5].transform.position;
                        Movement = RoomPos.Outside;
                    }
                    else if (NoVaat == false)
                    {
                        UIMAN.AfwasActive = true;
                    }
                }


                break;
            case RoomPos.Outside:

                dist = Vector3.Distance(waypoints[5].transform.position, transform.position);
                if (dist <= 1 && UIMAN.PlantenWaterenActive == false)
                {
                    if (NoPlant == true)
                    {
                        agent.destination = waypoints[0].transform.position;
                        Movement = RoomPos.BedroomEnum;
                    }
                    else if (NoPlant == false)
                    {
                        UIMAN.PlantenWaterenActive = true;
                    }
                }
                break;
        }
    }
}

