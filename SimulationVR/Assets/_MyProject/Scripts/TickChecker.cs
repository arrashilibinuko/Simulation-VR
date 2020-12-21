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

    private void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Tick1.GetComponent<MeshRenderer>().material = CompleteMaterial;
        }
        if (Input.GetMouseButtonDown(2))
        {
            Tick2.GetComponent<MeshRenderer>().material = CompleteMaterial;
        }
        if (Input.GetMouseButtonDown(3))
        {
            Tick3.GetComponent<MeshRenderer>().material = CompleteMaterial;
        }
    }
}
