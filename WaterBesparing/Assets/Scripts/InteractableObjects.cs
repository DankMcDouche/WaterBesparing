using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{
    public Image waterSlider; 

    public Button EersteButton;
    public Button Keuze1;
    public Button Keuze2;
    public Button Keuze3;
    public Button Keuze4;

     

    public void Start()
    {
        EersteButton.gameObject.SetActive(true);
        Keuze1.gameObject.SetActive(false);
        Keuze2.gameObject.SetActive(false);
        Keuze3.gameObject.SetActive(false);
        Keuze4.gameObject.SetActive(false);



    }
    public void ActiveButton()
    {
        EersteButton.gameObject.SetActive(false);
        Keuze1.gameObject.SetActive(true);
        Keuze2.gameObject.SetActive(true);
        Keuze3.gameObject.SetActive(true);
        Keuze4.gameObject.SetActive(true);

    }

    public void AddWater()
    {
        if(EersteButton == true)
        {
            if (Keuze1 == true)
            {
                waterSlider.fillAmount = 0.1f;
            }
            if (Keuze2 == true)
            {
                waterSlider.fillAmount = 0.2f;
            }
            if (Keuze3 == true)
            {
                waterSlider.fillAmount = 0.3f;
            }
            if (Keuze4 == true)
            {
                waterSlider.fillAmount = 0.4f;
            }
        }
        

    }
    public void Update()
    {
        
    }
}
