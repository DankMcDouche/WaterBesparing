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

    void Start()
    {
        DontDestroyOnLoad(this);
    }
    void Update()
    {
        if (AfwasActive)
        {
            AfwasKeuze_1.SetActive(true);
            AfwasKeuze_2.SetActive(true);
            AfwasKeuze_3.SetActive(true);
        }

        if (ToiletActive)
        {
            ToiletKeuze_1.SetActive(true);
            ToiletKeuze_2.SetActive(true);
            ToiletKeuze_3.SetActive(true);
        }

        if (PlantenWaterenActive)
        {
            PlantenWaterenKeuze_1.SetActive(true);
            PlantenWaterenKeuze_2.SetActive(true);
            PlantenWaterenKeuze_3.SetActive(true);
        }

        if (WasmachineActive)
        {
            WasmachineKeuze_1.SetActive(true);
            WasmachineKeuze_2.SetActive(true);
            WasmachineKeuze_3.SetActive(true);
        }

        if (OpschonenActive)
        {
            OpschonenKeuze_1.SetActive(true);
            OpschonenKeuze_2.SetActive(true);
            OpschonenKeuze_3.SetActive(true);
        }
    }

}
