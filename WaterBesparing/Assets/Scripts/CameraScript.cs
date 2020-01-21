using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public List<GameObject> RoomPositions;

    private PlayerScript Player;

    RoomPos PlayerEnum;

    public int rooms;

    void Start()
    {
        Player = GameObject.Find("Polly").GetComponent<PlayerScript>();
        PlayerEnum = Player.Movement;
    }
    void Update()
    {
        switch (Player.Movement)
        {
            case RoomPos.BedroomEnum:
                rooms = 0;
                Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 1 * Time.deltaTime);
                Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, RoomPositions[rooms].transform.rotation, 1 * Time.deltaTime);
                break;
            case RoomPos.BathroomEnum:
                rooms = 1;
                Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 1 * Time.deltaTime);
                Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, RoomPositions[rooms].transform.rotation, 1 * Time.deltaTime);
                break;
            case RoomPos.KitchenEnum:
                rooms = 2;
                Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 1 * Time.deltaTime);
                Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, RoomPositions[rooms].transform.rotation, 1 * Time.deltaTime);

                break;
            case RoomPos.Garage:
                rooms = 3;
                Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 1 * Time.deltaTime);
                Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, RoomPositions[rooms].transform.rotation, 1 * Time.deltaTime);

                break;
            case RoomPos.Outside:
                rooms = 4;
                Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, RoomPositions[rooms].transform.position, 1 * Time.deltaTime);
                Camera.main.transform.rotation = Quaternion.Lerp(Camera.main.transform.rotation, RoomPositions[rooms].transform.rotation, 1 * Time.deltaTime);
                break;
        }

        
    }

}
