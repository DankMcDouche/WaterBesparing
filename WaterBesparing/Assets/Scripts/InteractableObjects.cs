using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{
    public Image waterSlider; 

    public Button Keuze0;
    public Button Keuze1;
    public Button Keuze2;
    public Button Keuze3;

     

    public void Start()
    {
        Keuze0.gameObject.SetActive(true);
        Keuze1.gameObject.SetActive(false);
        Keuze2.gameObject.SetActive(false);
        Keuze3.gameObject.SetActive(false);

        
        
    }
    public void ActiveButton()
    {
        Keuze0.gameObject.SetActive(false);
        Keuze1.gameObject.SetActive(true);
        Keuze2.gameObject.SetActive(true);
        Keuze3.gameObject.SetActive(true);
    }

    public void AddWater()
    {
        if(Keuze1 == true)
        {
            waterSlider.fillAmount = 0.1f;
            
        }
            
    }
    public void Update()
    {
        
    }
}
