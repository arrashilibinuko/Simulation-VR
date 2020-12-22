using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TickChecker : MonoBehaviour
{

    public Material CompleteMaterial;
    public GameObject Tick1;
    public GameObject Tick2;
    public GameObject Tick3;

    public bool Check1 = false;
    public bool Check2 = false;
    public bool Check3 = false;


    public void enableTick(string zoneName)
    {
        if (zoneName == "wetFloorSign")
        {
            Debug.Log(zoneName);
            Tick1.GetComponent<MeshRenderer>().material = CompleteMaterial;
            Check1 = true;
        }
    }

    public void checkIfComplete()
    {
        if (Check1 == true)
        {
            Debug.Log("win");
            //Application.LoadLevel("Win");
        }
    }


    private void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
       // checkIfComplete();
    }
}
