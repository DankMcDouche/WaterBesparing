using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{
    enum rooms
    {
        Shower,
        Toilet,
        Wash,
        Vaat,
        Plant
    }

    UImanager UIman;
    PlayerScript Player;

    rooms Questions;

    public Image waterSlider;
    public int Water;
                  
    public Button AfwasKeuze_1;
    public Button AfwasKeuze_2;
    public Button AfwasKeuze_3;
    public Button ToiletKeuze_1;
    public Button ToiletKeuze_2;
    public Button ToiletKeuze_3;
    public Button OpschonenKeuze_1;
    public Button OpschonenKeuze_2;
    public Button OpschonenKeuze_3;
    public Button WasmachineKeuze_1;
    public Button WasmachineKeuze_2;
    public Button WasmachineKeuze_3;
    public Button PlantenWaterenKeuze_1;
    public Button PlantenWaterenKeuze_2;
    public Button PlantenWaterenKeuze_3;



    public void Start()
    {
        UIman = GameObject.Find("UIManager").GetComponent<UImanager>();
        Player = GameObject.Find("Polly").GetComponent<PlayerScript>();
        Questions = rooms.Shower;
    }
   
    public void AddWater()
    {

        switch (Questions)
        {
            case rooms.Shower:
                if (OpschonenKeuze_1 == true)
                {
                    print("i press button");
                    waterSlider.fillAmount += 0.15f;
                    UIman.OpschonenActive = false;
                    Player.NoShower = true;
                    Questions = rooms.Toilet;
                }
                else if (OpschonenKeuze_2 == true)
                {
                    waterSlider.fillAmount += 0.1f;
                    UIman.OpschonenActive = false;
                    print("i press button");
                    Player.NoShower = true;
                    Questions = rooms.Toilet;
                }
                else if (OpschonenKeuze_3 == true)
                {
                    waterSlider.fillAmount += 0.05f;
                    UIman.OpschonenActive = false;
                    print("i press button");
                    Player.NoShower = true;
                    Questions = rooms.Toilet;
                }
                break;
            case rooms.Toilet:
                if (ToiletKeuze_1 == true)
                {
                    print("toiletButton activate");
                    waterSlider.fillAmount += 0.15f;
                    UIman.ToiletActive = false;
                    Player.NoToilet = true;
                    Questions = rooms.Wash;
                }
                else if (ToiletKeuze_2 == true)
                {
                    waterSlider.fillAmount += 0.1f;
                    UIman.ToiletActive = false;
                    Player.NoToilet = true;
                    Questions = rooms.Wash;
                }
                else if (ToiletKeuze_3 == true)
                {
                    waterSlider.fillAmount += 0.05f;
                    UIman.ToiletActive = false;
                    Player.NoToilet = true;
                    Questions = rooms.Wash;
                }
                break;
            case rooms.Wash:
                if (WasmachineKeuze_1 == true)
                {
                    waterSlider.fillAmount += 0.15f;
                    UIman.WasmachineActive = false;
                    Player.NoWash = true;
                    Questions = rooms.Vaat;
                }
                else if (WasmachineKeuze_2 == true)
                {
                    waterSlider.fillAmount += 0.1f;
                    UIman.WasmachineActive = false;
                    Player.NoWash = true;
                    Questions = rooms.Vaat;
                }
                else if (WasmachineKeuze_3 == true)
                {
                    waterSlider.fillAmount += 0.05f;
                    UIman.WasmachineActive = false;
                    Player.NoWash = true;
                    Questions = rooms.Vaat;
                }
                break;
            case rooms.Vaat:
                if (AfwasKeuze_1 == true)
                {
                    waterSlider.fillAmount += 0.15f;
                    UIman.AfwasActive = false;
                    Player.NoVaat = true;
                    Questions = rooms.Plant;
                }
                else if (AfwasKeuze_2 == true)
                {
                    waterSlider.fillAmount += 0.1f;
                    UIman.AfwasActive = false;
                    Player.NoVaat = true;
                    Questions = rooms.Plant;
                }
                else if (AfwasKeuze_3 == true)
                {
                    waterSlider.fillAmount += 0.05f;
                    UIman.AfwasActive = false;
                    Player.NoVaat = true;
                    Questions = rooms.Plant;
                }
                break;
            case rooms.Plant:
                if (PlantenWaterenKeuze_1 == true)
                {
                    waterSlider.fillAmount += 0.15f;
                    UIman.PlantenWaterenActive = false;
                    Player.NoPlant = true;
                    Questions = rooms.Shower;
                }
                else if (PlantenWaterenKeuze_2 == true)
                {
                    waterSlider.fillAmount += 0.1f;
                    UIman.PlantenWaterenActive = false;
                    Player.NoPlant = true;
                    Questions = rooms.Shower;
                }
                else if (PlantenWaterenKeuze_3 == true)
                {
                    waterSlider.fillAmount += 0.05f;
                    UIman.PlantenWaterenActive = false;
                    Player.NoPlant = true;
                    Questions = rooms.Shower;
                }
                break;

        }

        //if (OpschonenKeuze_1 == true)
        //{
        //    print("i press button");
        //     waterSlider.fillAmount += 0.15f;
        //     UIman.OpschonenActive = false;
        //     Player.NoShower = true;
        // }
        // else if (OpschonenKeuze_2 == true)
        // {
        //     waterSlider.fillAmount += 0.1f;
        //     UIman.OpschonenActive = false;
        //    print("i press button");
        //    Player.NoShower = true;
        //}
        // else if (OpschonenKeuze_3 == true)
        // {
        //     waterSlider.fillAmount += 0.05f;
        //     UIman.OpschonenActive = false;
        //    print("i press button");
        //    Player.NoShower = true;
        //}

//----------------------------------------------------
//        else if (ToiletKeuze_1 == true)
//        {
//            print("toiletButton activate");
//            waterSlider.fillAmount += 0.15f;
//            UIman.ToiletActive = false;
//            Player.NoToilet = true;
//        }
//        else if (ToiletKeuze_2 == true)
//        {
//            waterSlider.fillAmount += 0.1f;
//            UIman.ToiletActive = false;
//            Player.NoToilet = true;
//        }
//        else if (ToiletKeuze_3 == true)
//        {
//            waterSlider.fillAmount += 0.05f;
//            UIman.ToiletActive = false;
//            Player.NoToilet = true;
//        }
////----------------------------------------------------
//        else if (WasmachineKeuze_1 == true)
//        {
//            waterSlider.fillAmount += 0.15f;
//            UIman.WasmachineActive = false;
//            Player.NoWash = true;
//        }
//        else if (WasmachineKeuze_2 == true)
//        {
//            waterSlider.fillAmount += 0.1f;
//            UIman.WasmachineActive = false;
//            Player.NoWash = true;
//        }
//        else if (WasmachineKeuze_3 == true)
//        {
//            waterSlider.fillAmount += 0.05f;
//            UIman.WasmachineActive = false;
//            Player.NoWash = true;
//        }
////----------------------------------------------------
//        else if (AfwasKeuze_1 == true)
//        {
//            waterSlider.fillAmount += 0.15f;
//            UIman.AfwasActive = false;
//            Player.NoVaat = true;
//        }
//        else if (AfwasKeuze_2 == true)
//        {
//            waterSlider.fillAmount += 0.1f;
//            UIman.AfwasActive = false;
//            Player.NoVaat = true;
//        }
//        else if (AfwasKeuze_3 == true)
//        {
//            waterSlider.fillAmount += 0.05f;
//            UIman.AfwasActive = false;
//            Player.NoVaat = true;
//        }
////----------------------------------------------------
//        else if (PlantenWaterenKeuze_1 == true)
//        {
//            waterSlider.fillAmount += 0.15f;
//            UIman.PlantenWaterenActive = false;
//            Player.NoPlant = true;
//        }
//        else if (PlantenWaterenKeuze_2 == true)
//        {
//            waterSlider.fillAmount += 0.1f;
//            UIman.PlantenWaterenActive = false;
//            Player.NoPlant = true;
//        }
//        else if (PlantenWaterenKeuze_3 == true)
//        {
//            waterSlider.fillAmount += 0.05f;
//            UIman.PlantenWaterenActive = false;
//            Player.NoPlant = true;
//        }
//----------------------------------------------------


    }


}
  