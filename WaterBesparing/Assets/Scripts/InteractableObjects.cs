using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{
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
        AfwasKeuze_1.gameObject.SetActive(false);
        AfwasKeuze_2.gameObject.SetActive(false);
        AfwasKeuze_3.gameObject.SetActive(false);

        ToiletKeuze_1.gameObject.SetActive(false);
        ToiletKeuze_2.gameObject.SetActive(false);
        ToiletKeuze_3.gameObject.SetActive(false);

        OpschonenKeuze_1.gameObject.SetActive(false);
        OpschonenKeuze_2.gameObject.SetActive(false);
        OpschonenKeuze_3.gameObject.SetActive(false);

        WasmachineKeuze_1.gameObject.SetActive(false);
        WasmachineKeuze_2.gameObject.SetActive(false);
        WasmachineKeuze_3.gameObject.SetActive(false);

        PlantenWaterenKeuze_1.gameObject.SetActive(false);
        PlantenWaterenKeuze_2.gameObject.SetActive(false);
        PlantenWaterenKeuze_3.gameObject.SetActive(false);
    }
   
    public void AddWater()
    {
       
            if (Keuze1 == true)
            {
                waterSlider.fillAmount += 0.15f;
            }
            if (Keuze2 == true)
            {
                waterSlider.fillAmount += 0.1f;
            }
            if (Keuze3 == true)
            {
                waterSlider.fillAmount += 0.05f;
            }
        }
        

}
  