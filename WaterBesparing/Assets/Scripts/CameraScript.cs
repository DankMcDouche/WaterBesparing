using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public List<GameObject> RoomPositions;

    private PlayerScript Player;

    RoomPos PlayerEnum;

    public int rooms;

    bool LeftRotation;

    //PlayerScript player = new PlayerScript();


    void Start()
    {
        //Player = GameObject.Find("Player").GetComponent<PlayerScript>();

    }
    void Update()
    {
        if (PlayerEnum == RoomPos.BedroomEnum)
        {
            rooms = 0;
            Camera.main.transform.position = RoomPositions[rooms].transform.position;
            Camera.main.transform.rotation = RoomPositions[rooms].transform.rotation;
        }
        else if (PlayerEnum == RoomPos.BathroomEnum)
        {
            print("but now it doent");
            rooms = 1;
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 0.05f);
            Camera.main.transform.rotation = RoomPositions[rooms].transform.rotation;
        }
        else if (PlayerEnum == RoomPos.KitchenEnum)
        {
            print("but now it doent");
            rooms = 2;
            Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 0.1f);
            Camera.main.transform.rotation = RoomPositions[rooms].transform.rotation;
        }

    }

}
