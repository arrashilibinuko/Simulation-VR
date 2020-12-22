using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TickChecker : MonoBehaviour
{

    public Material CompleteMaterial;
    public GameObject Tick1;
    public GameObject Tick2;
    public GameObject Tick3;

    public bool Check1;
    public bool Check2;
    public bool Check3;


    public void enableTick(string zoneName)
    {
        if (zoneName == "wetFloorSign")
        {
            Debug.Log(zoneName);
            Tick1.GetComponent<MeshRenderer>().material = CompleteMaterial;
        }
    }


    private void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
