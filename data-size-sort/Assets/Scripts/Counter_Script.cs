using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            // Level 2 is loaded once Level 1 is completed
            SceneManager.LoadScene("Level2");
        }
    }
}
