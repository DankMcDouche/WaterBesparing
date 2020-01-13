using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{
    public Image waterSlider;
    public int Water; 

    public Button Keuze1;
    public Button Keuze2;
    public Button Keuze3;

     

    public void Start()
    {
        Keuze1.gameObject.SetActive(true);
        Keuze2.gameObject.SetActive(true);
        Keuze3.gameObject.SetActive(true);



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
  