using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public EndPoint[] endPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool complete = true;
        for(int i = 0;i < endPoints.Length; i++)
        {
            if (!endPoints[i].isFull())
            {
                complete = false;
            }
        }
        if (complete)
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1)%2);
        }
    }
}
