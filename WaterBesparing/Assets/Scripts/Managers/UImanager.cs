using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{


    [SerializeField] public GameObject AfwasKeuze_1;
    [SerializeField] public GameObject AfwasKeuze_2;
    [SerializeField] public GameObject AfwasKeuze_3;

    [SerializeField] public GameObject ToiletKeuze_1;
    [SerializeField] public GameObject ToiletKeuze_2;
    [SerializeField] public GameObject ToiletKeuze_3;

    [SerializeField] public GameObject OpschonenKeuze_1;
    [SerializeField] public GameObject OpschonenKeuze_2;
    [SerializeField] public GameObject OpschonenKeuze_3;

    [SerializeField] public GameObject WasmachineKeuze_1;
    [SerializeField] public GameObject WasmachineKeuze_2;
    [SerializeField] public GameObject WasmachineKeuze_3;

    [SerializeField] public GameObject PlantenWaterenKeuze_1;
    [SerializeField] public GameObject PlantenWaterenKeuze_2;
    [SerializeField] public GameObject PlantenWaterenKeuze_3;

    public bool AfwasActive;
    public bool ToiletActive;
    public bool PlantenWaterenActive;
    public bool WasmachineActive;
    public bool OpschonenActive;

    public bool OpschonenF;
    public bool ToiletF;
    public bool WasF;
    public bool VaatF;
    public bool PlantF;

    void Start()
    {
        DontDestroyOnLoad(this);
        //AfwasKeuze_1.gameObject.SetActive(false);
        //AfwasKeuze_2.gameObject.SetActive(false);
        //AfwasKeuze_3.gameObject.SetActive(false);

        //ToiletKeuze_1.gameObject.SetActive(false);
        //ToiletKeuze_2.gameObject.SetActive(false);
        //ToiletKeuze_3.gameObject.SetActive(false);

        //OpschonenKeuze_1.gameObject.SetActive(false);
        //OpschonenKeuze_2.gameObject.SetActive(false);
        //OpschonenKeuze_3.gameObject.SetActive(false);

        //WasmachineKeuze_1.gameObject.SetActive(false);
        //WasmachineKeuze_2.gameObject.SetActive(false);
        //WasmachineKeuze_3.gameObject.SetActive(false);

        //PlantenWaterenKeuze_1.gameObject.SetActive(false);
        //PlantenWaterenKeuze_2.gameObject.SetActive(false);
        //PlantenWaterenKeuze_3.gameObject.SetActive(false);

        //OpschonenF = false;
        //ToiletF = false;
        //WasF = false;
        //VaatF = false;
        //PlantF = false;

    }
    void Update()
    {
        print(OpschonenActive);

        if (OpschonenActive == true)
        {
            OpschonenKeuze_1.SetActive(true);
            OpschonenKeuze_2.SetActive(true);
            OpschonenKeuze_3.SetActive(true);
        }
        else if (OpschonenActive == false)
        {
            OpschonenKeuze_1.gameObject.SetActive(false);
            OpschonenKeuze_2.gameObject.SetActive(false);
            OpschonenKeuze_3.gameObject.SetActive(false);
        }
        if (ToiletActive)
        {

            ToiletKeuze_1.SetActive(true);
            ToiletKeuze_2.SetActive(true);
            ToiletKeuze_3.SetActive(true);
        }
        else
        {
            ToiletKeuze_1.gameObject.SetActive(false);
            ToiletKeuze_2.gameObject.SetActive(false);
            ToiletKeuze_3.gameObject.SetActive(false);
        }
        if (WasmachineActive)
        {
            WasmachineKeuze_1.SetActive(true);
            WasmachineKeuze_2.SetActive(true);
            WasmachineKeuze_3.SetActive(true);
        }
        else
        {
            WasmachineKeuze_1.gameObject.SetActive(false);
            WasmachineKeuze_2.gameObject.SetActive(false);
            WasmachineKeuze_3.gameObject.SetActive(false);
        }
        if (AfwasActive)
        {

            AfwasKeuze_1.SetActive(true);
            AfwasKeuze_2.SetActive(true);
            AfwasKeuze_3.SetActive(true);
        }
        else
        {
            AfwasKeuze_1.gameObject.SetActive(false);
            AfwasKeuze_2.gameObject.SetActive(false);
            AfwasKeuze_3.gameObject.SetActive(false);

        }
        if (PlantenWaterenActive)
        {

            PlantenWaterenKeuze_1.SetActive(true);
            PlantenWaterenKeuze_2.SetActive(true);
            PlantenWaterenKeuze_3.SetActive(true);
        }
        else
        {
            PlantenWaterenKeuze_1.gameObject.SetActive(false);
            PlantenWaterenKeuze_2.gameObject.SetActive(false);
            PlantenWaterenKeuze_3.gameObject.SetActive(false);
        }
    }

}
