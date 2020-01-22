using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerWater : MonoBehaviour
{
    public Text PlayerWaterText;
    UImanager UIMAN;
    void Start()
    {
        UIMAN = GameObject.Find("UIManager").GetComponent<UImanager>();
        PlayerWaterText.text = "Jouw gebruikte water : " + UIMAN.WaterUI.ToString() + "L";
    }


}
