﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class InteractableObjects : MonoBehaviour
{

    public Button WC;
    public Button Keuze1;
    public Button Keuze2;
    public Button Keuze3;
    public Button Keuze4;


    void OnEnable()
    {
        WC.gameObject.SetActive(true);
        Keuze1.gameObject.SetActive(false);
        Keuze2.gameObject.SetActive(false);
        Keuze3.gameObject.SetActive(false);
        Keuze4.gameObject.SetActive(false);

    }

    private void disableAllButtons()
    {
        WC.gameObject.SetActive(false);
        Keuze1.gameObject.SetActive(false);
        Keuze2.gameObject.SetActive(false);
        Keuze3.gameObject.SetActive(false);
        Keuze4.gameObject.SetActive(false);
    }

    public void EnableButton(Button _toEnable)
    {
        disableAllButtons();
        _toEnable.gameObject.SetActive(true);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
