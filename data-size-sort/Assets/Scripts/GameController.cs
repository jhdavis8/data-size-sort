﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GameController: handles whether to progress the scene or not, other global checks
 */
public class GameController : MonoBehaviour
{
    public Box[] boxes;
    public GUISkin skin;
    private bool complete;
    private Box somethingHeld;
    private bool intro1_complete = false;
    private bool intro2_complete = false;
    public Check checkBox;
    public EndPoint[] endPoints;

    private void Start()
    {
        somethingHeld = null;
    }

    /*
    * Called once per frame. This checks if all Boxes in the scene are in the correct end position 
    */
    void Update()
    {
        complete = true;
        for (int i = 0; i < boxes.Length; i++)
        {
            if (!boxes[i].CorrectDrop())
            {
                complete = false;
            }
        }
        if (checkBox.check())
        {
            ColorBoxes();
            if (complete)
            {
                Debug.Log("Complete");
                SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 3);
            }
            else
            {
                checkBox.setCheck();
                Debug.Log("Not all correct");
            }
        }
        
    }

    private void ColorBoxes()
    {
        for (int i = 0; i < boxes.Length; i++)
        {
            if (boxes[i].CorrectDrop())
            {
                endPoints[i].GetComponent<SpriteRenderer>().color = Color.green;
            }
            else
            {
                endPoints[i].GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }

    void OnGUI()
    {
        GUI.skin = skin;
        Debug.Log(SceneManager.GetActiveScene().name);
        if (!intro1_complete && SceneManager.GetActiveScene().name == "Level1")
        {
            GUI.Box(new Rect(100, 100, 600, 400),
                "Welcome to Data Size Sort. In this level, you need to order the various data size labels from smallest to largest." +
                "\n -- You can pick up a label by clicking on it and dragging.\n -- Release each box into the black end points to sort them. " +
                "\n -- Press check when you have finished to see if you are correct, and press hint to see a hint. " +
                "\n -- Reset will return all the labels to their starting positions.");
            if (GUI.Button(new Rect(350, 350, 100, 50), "OK"))
            {
                intro1_complete = true;
            }
        }
        else if (!intro2_complete && SceneManager.GetActiveScene().name == "Level2")
        {
            GUI.Box(new Rect(100, 100, 600, 400),
                "This is the introduction and instructions to Level 2.");
            if (GUI.Button(new Rect(350, 350, 100, 50), "OK"))
            {
                intro2_complete = true;
            }
        }
    }
    
    /*
     * Sets the value of somethingHeld
     */
    public void setHeld(Box setting)
    {
        somethingHeld = setting;
    }

    /*
     * Returns the value of somethingHeld
     */
    public Box whatIsHeld()
    {
        return somethingHeld;
    }
       
    public bool isComplete()
    {
        return complete;
    }

}
