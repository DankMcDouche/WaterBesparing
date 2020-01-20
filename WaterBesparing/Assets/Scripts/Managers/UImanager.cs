using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{

    [SerializeField] public GameObject KitchenKeuze_1; 
    public bool kitchenActive; 
    void Start()
    {
        DontDestroyOnLoad(this); 
    }
    void Update()
    {
        if(kitchenActive)
        {
            KitchenKeuze_1.gameObject.SetActive(true); 
        }
    }
}
