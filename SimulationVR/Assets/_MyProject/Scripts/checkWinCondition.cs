using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkWinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkIfAllCompleted()
    {
        if (GameObject.Find("taskList").GetComponent<TickChecker>().Check1 == true)
        {
            //Debug.Log(GameObject.Find("taskList").GetComponent<TickChecker>().Check1);
            Application.LoadLevel("Win");
        } else
        {
            Debug.Log("not completed yet");
        }
        
    }
}
