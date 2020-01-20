using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{

    //[SerializeField] public GameObject KitchenKeuze_1;
    //[SerializeField] public GameObject KitchenKeuze_2; 
    //[SerializeField] public GameObject KitchenKeuze_3; 

    //[SerializeField] public GameObject KitchenKeuze_1; 
    //[SerializeField] public GameObject KitchenKeuze_2; 
    //[SerializeField] public GameObject KitchenKeuze_3; 

    //[SerializeField] public GameObject KitchenKeuze_1; 
    //[SerializeField] public GameObject KitchenKeuze_2; 
    //[SerializeField] public GameObject KitchenKeuze_3; 

    //[SerializeField] public GameObject KitchenKeuze_1; 
    //[SerializeField] public GameObject KitchenKeuze_2; 
    //[SerializeField] public GameObject KitchenKeuze_3; 

    //[SerializeField] public GameObject KitchenKeuze_1; 
    //[SerializeField] public GameObject KitchenKeuze_2; 
    //[SerializeField] public GameObject KitchenKeuze_3;

    // bool kitchenActive; 
    void Start()
    {
        DontDestroyOnLoad(this); 
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            KitchenKeuze_1.gameObject.SetActive(true); 
        }
    }
}
