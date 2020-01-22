using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{
    UImanager UIman;

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
       
    }
   
    public void AddWater()
    {

        if (OpschonenKeuze_1 == true)
        {
            waterSlider.fillAmount += 0.15f;
            UIman.OpschonenActive = false; 
        }
        if (OpschonenKeuze_2 == true)
        {
            waterSlider.fillAmount += 0.1f;
            UIman.OpschonenActive = false;
        }
        if (OpschonenKeuze_3 == true)
        {
            waterSlider.fillAmount += 0.05f;
            UIman.OpschonenActive = false;
        }

        //    if (AfwasKeuze_1 == true)
        //    {
        //        waterSlider.fillAmount += 0.15f;
        //    }
        //    if (AfwasKeuze_2 == true)
        //    {
        //        waterSlider.fillAmount += 0.1f;
        //    }
        //    if (AfwasKeuze_3 == true)
        //    {
        //        waterSlider.fillAmount += 0.05f;
        //    }
    }
        

}
  