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
    PlayerWater playerwater;

    rooms Questions;

    public Image waterSlider;
    public float Water;
                  
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

    public void Update()
    {
        print(Water);
        UIman.WaterUI = Water;
        
    }

    //meeste water 701,2L
    //minste water 252,6L
    //neutraal water 0L

    public void AddWaterShower()
    {
        if (OpschonenKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.083f;
            UIman.OpschonenActive = false;
            Player.NoShower = true;
            print("OpschoonKeuze 1 clicked");
            Water += 120f;
        }
    }
    public void AddWaterShower2()
    {
        if (OpschonenKeuze_2 == true)
        {
            waterSlider.fillAmount += 0f;
            UIman.OpschonenActive = false;
            Player.NoShower = true;
            print("OpschoonKeuze 2 clicked");
        } 
    }
    public void AddWaterShower3()
    {
      if (OpschonenKeuze_3 == true)
      {
          waterSlider.fillAmount += 0.043f;
          UIman.OpschonenActive = false;
          Player.NoShower = true;
          print("OpschoonKeuze 3 clicked");
            Water += 60f;
        }
    }
    public void AddWaterAfwas()
    {
        if (AfwasKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.099f;
            UIman.AfwasActive = false;
            Player.NoVaat = true;
            print("AfwasKeuze_1 clicked");
            Water += 16;
        }
    }
    public void AddWaterAfwas2()
    {
        if (AfwasKeuze_2 == true)
        {
            waterSlider.fillAmount += 0f;
            UIman.AfwasActive = false;
            Player.NoVaat = true;
            print("AfwasKeuze_2 clicked");
        }
    }
    public void AddWaterAfwas3()
    {
        if (AfwasKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.078f;
            UIman.AfwasActive = false;
            Player.NoVaat = true;
            print("AfwasKeuze_3 clicked");
            Water += 5.5f;
        }
    }
    public void AddWaterWasmachine()
    {
        if (WasmachineKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.100f;
            UIman.WasmachineActive = false;
            Player.NoWash = true;
            print("WasmachineKeuze_1 clicked");
            Water += 14;
        }
    }
    public void AddWaterWasmachine2()
    {
        if (WasmachineKeuze_2 == true)
        {
            waterSlider.fillAmount += 0f;
            UIman.WasmachineActive = false;
            Player.NoWash = true;
            print("WasmachineKeuze_2 clicked");
        }
    }
    public void AddWaterWasmachine3()
    {
        if (WasmachineKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.010f;
            UIman.WasmachineActive = false;
            Player.NoWash = true;
            print("WasmachineKeuze_3 clicked");
            Water += 1.5f;
        }  
    }
    public void AddWaterPlanten()
    {
        if (PlantenWaterenKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.77f;
            UIman.PlantenWaterenActive = false;
            Player.NoPlant = true;
            Questions = rooms.Shower;
            print("PlantenWaterenKeuze_1 clicked");
            Water += 540;
        }
    }
    public void AddWaterPlanten2()
    {
        if (PlantenWaterenKeuze_2 == true)
        {
            waterSlider.fillAmount += 0f;
            UIman.PlantenWaterenActive = false;
            Player.NoPlant = true;
            Questions = rooms.Shower;
            print("PlantenWaterenKeuze_2 clicked");
        }
    }
    public void AddWaterPlanten3()
    {
        if (PlantenWaterenKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.25f;
            UIman.PlantenWaterenActive = false;
            Player.NoPlant = true;
            Questions = rooms.Shower;
            print("PlantenWaterenKeuze_3 clicked");
            Water += 180;
        }
    }
    public void AddWaterToilet()
    {
        if (ToiletKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.080f;
            UIman.ToiletActive = false;
            Player.NoToilet = true;
            print("ToiletKeuze_1 clicked");
            Water += 11.2f;

        }
    }
    public void AddWaterToilet2()
    {
        if (ToiletKeuze_2 == true)
        {
            waterSlider.fillAmount += 0f;
            UIman.ToiletActive = false;
            Player.NoToilet = true;
            print("ToiletKeuze_2 clicked");
        }
    }
    public void AddWaterToilet3()
    {
        if (ToiletKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.040f;
            UIman.ToiletActive = false;
            Player.NoToilet = true;
            print("ToiletKeuze_3 clicked");
            Water += 5.6f;
        }
    }
}
  