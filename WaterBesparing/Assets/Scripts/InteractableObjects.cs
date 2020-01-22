using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

enum rooms
{
    Shower,
    Toilet,
    Wash,
    Vaat,
    Plant
}
public class InteractableObjects : MonoBehaviour
{
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

    public void AddWaterShower()
    {
        if (OpschonenKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.15f;
            UIman.OpschonenActive = false;
            Player.NoShower = true;
            print("OpschoonKeuze 1 clicked");
        }
        else if (OpschonenKeuze_2 == true)
        {
            waterSlider.fillAmount += 0.1f;
            UIman.OpschonenActive = false;
            Player.NoShower = true;
            print("OpschoonKeuze 2 clicked");
        }
        else if (OpschonenKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.05f;
            UIman.OpschonenActive = false;
            Player.NoShower = true;
            print("OpschoonKeuze 3 clicked");
        }
    }
    public void AddWaterToilet()
    {
        if (ToiletKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.15f;
            UIman.ToiletActive = false;
            Player.NoToilet = true;
            print("ToiletKeuze_1 clicked");

        }
        else if (ToiletKeuze_2 == true)
        {
            waterSlider.fillAmount += 0.1f;
            UIman.ToiletActive = false;
            Player.NoToilet = true;
            print("ToiletKeuze_2 clicked");

        }
        else if (ToiletKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.05f;
            UIman.ToiletActive = false;
            Player.NoToilet = true;
            print("ToiletKeuze_3 clicked");
        }
    }
    public void AddWaterWasmachine()
    {
        if (WasmachineKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.15f;
            UIman.WasmachineActive = false;
            Player.NoWash = true;
            print("WasmachineKeuze_1 clicked");
        }
        else if (WasmachineKeuze_2 == true)
        {
            waterSlider.fillAmount += 0.1f;
            UIman.WasmachineActive = false;
            Player.NoWash = true;
            print("WasmachineKeuze_2 clicked");
        }
        else if (WasmachineKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.05f;
            UIman.WasmachineActive = false;
            Player.NoWash = true;
            print("WasmachineKeuze_3 clicked");
        }
    }
    public void AddWaterAfwas()
    {
        if (AfwasKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.15f;
            UIman.AfwasActive = false;
            Player.NoVaat = true;
            print("AfwasKeuze_1 clicked");
        }
        else if (AfwasKeuze_2 == true)
        {
            waterSlider.fillAmount += 0.1f;
            UIman.AfwasActive = false;
            Player.NoVaat = true;
            print("AfwasKeuze_2 clicked");
        }
        else if (AfwasKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.05f;
            UIman.AfwasActive = false;
            Player.NoVaat = true;
            print("AfwasKeuze_3 clicked");
        }
    }
    public void AddWaterPlanten()
    {
        if (PlantenWaterenKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.15f;
            UIman.PlantenWaterenActive = false;
            Player.NoPlant = true;
            Questions = rooms.Shower;
            print("PlantenWaterenKeuze_1 clicked");
        }
        else if (PlantenWaterenKeuze_2 == true)
        {
            waterSlider.fillAmount += 0.1f;
            UIman.PlantenWaterenActive = false;
            Player.NoPlant = true;
            Questions = rooms.Shower;
            print("PlantenWaterenKeuze_2 clicked");
        }
        else if (PlantenWaterenKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.05f;
            UIman.PlantenWaterenActive = false;
            Player.NoPlant = true;
            Questions = rooms.Shower;
            print("PlantenWaterenKeuze_3 clicked");
        }
    }
    //public void AddWater()
    //{
    //    switch (Questions)
    //    {
    //            break;
    //        case rooms.Vaat:
    //            if (AfwasKeuze_1 == true)
    //            {
    //                waterSlider.fillAmount += 0.15f;
    //                UIman.AfwasActive = false;
    //                Player.NoVaat = true;
    //                Questions = rooms.Plant;
    //                print("AfwasKeuze_1 clicked");
    //            }
    //            else if (AfwasKeuze_2 == true)
    //            {
    //                waterSlider.fillAmount += 0.1f;
    //                UIman.AfwasActive = false;
    //                Player.NoVaat = true;
    //                Questions = rooms.Plant;
    //                print("AfwasKeuze_2 clicked");
    //            }
    //            else if (AfwasKeuze_3 == true)
    //            {
    //                waterSlider.fillAmount += 0.05f;
    //                UIman.AfwasActive = false;
    //                Player.NoVaat = true;
    //                Questions = rooms.Plant;
    //                print("AfwasKeuze_3 clicked");
    //            }
    //            break;
    //        case rooms.Plant:
    //            if (PlantenWaterenKeuze_1 == true)
    //            {
    //                waterSlider.fillAmount += 0.15f;
    //                UIman.PlantenWaterenActive = false;
    //                Player.NoPlant = true;
    //                Questions = rooms.Shower;
    //                print("PlantenWaterenKeuze_1 clicked");
    //            }
    //            else if (PlantenWaterenKeuze_2 == true)
    //            {
    //                waterSlider.fillAmount += 0.1f;
    //                UIman.PlantenWaterenActive = false;
    //                Player.NoPlant = true;
    //                Questions = rooms.Shower;
    //                print("PlantenWaterenKeuze_2 clicked");
    //            }
    //            else if (PlantenWaterenKeuze_3 == true)
    //            {
    //                waterSlider.fillAmount += 0.05f;
    //                UIman.PlantenWaterenActive = false;
    //                Player.NoPlant = true;
    //                Questions = rooms.Shower;
    //                print("PlantenWaterenKeuze_3 clicked");
    //            }
    //            break;
    //    }
    //}
}
  