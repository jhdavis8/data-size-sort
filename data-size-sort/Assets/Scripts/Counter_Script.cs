using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter_Script : MonoBehaviour
{
    //Checks each individual endpoint box
    public Box endpoint1;   
    public Box endpoint2;
    public Box endpoint3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(endpoint1.collided == true && endpoint2.collided == true && endpoint3.collided == true)
        {
            Debug.Log("GameOVer");
        }
    }
}
