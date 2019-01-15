﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GameController: handles whether to progress the scene or not, other global checks
 */
public class GameController : MonoBehaviour
{
    public EndPoint[] endPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
     * Called once per frame. This checks if all EndPoints in the scene are filled.
     */
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