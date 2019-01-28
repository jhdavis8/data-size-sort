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
    public GUISkin bigSkin;
    private bool complete;
    private bool show_end_message = true;
    private Box somethingHeld;
    private bool intro1_complete = false;
    private bool intro2_complete = false;
    private Rect boxDefault;
    private Rect boxBig;
    private Rect buttonDefault;
    private Rect buttonBig;
    private Rect boxUsed;
    private Rect buttonUsed;
    public Check checkBox;
    public EndPoint[] endPoints;

    private void Start()
    {
        somethingHeld = null;
        Debug.Log(Screen.currentResolution);
        boxDefault = new Rect(600, 100, 650, 450);
        boxBig = new Rect(boxDefault.x * 2, boxDefault.y * 2, boxDefault.width * 2, boxDefault.height * 2);
        buttonDefault = new Rect(875, 375, 100, 50);
        buttonBig = new Rect(buttonDefault.x * 2, buttonDefault.y * 2, buttonDefault.width * 2, buttonDefault.height * 2);
}

    /*
    * Called once per frame. This checks if all Boxes in the scene are in the correct end position 
    */
    void Update()
    {
        complete = true;
        show_end_message = false;
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
                show_end_message = true;
                Debug.Log("Complete");
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

    /*
     *  Called once per frame I think. Handles all the boxes and button for GUI messages at level start and end. 
     */
    void OnGUI()
    {
        if (Screen.currentResolution.ToString().Contains("3840"))
        {
            GUI.skin = bigSkin;
            boxUsed = boxBig;
            buttonUsed = buttonBig;
        }   
        else
        {
            GUI.skin = skin;
            boxUsed = boxDefault;
            buttonUsed = buttonDefault;
        }
        Debug.Log(SceneManager.GetActiveScene().name);
        if (!intro1_complete && SceneManager.GetActiveScene().name == "Level1")
        {
            GUI.Box(boxUsed,
                "Welcome to Data Size Sort. In this level, you need to order the various data size labels from smallest to largest." +
                "\n -- You can pick up a label by clicking on it and dragging." +
                "\n -- Release each box into the black end points to sort them. " +
                "\n -- Click check when you have finished to see if you are correct" +
                "\n -- Click hint to see a hint. " +
                "\n -- Click reset to send all the labels to their starting positions.");
            if (GUI.Button(buttonUsed, "OK"))
            {
                intro1_complete = true;
            }
        }
        else if (!intro2_complete && SceneManager.GetActiveScene().name == "Level2")
        {
            GUI.Box(boxUsed,
                "Now, categorize these various real-world examples of data sizes by which data size you think they best fit under." +
                "\n -- You can pick up a label by clicking on it and dragging." +
                "\n -- Release each box into the black end points to categorize them. " +
                "\n -- Click check when you have finished to see if you are correct." +
                "\n -- Click return to send all the labels to their starting positions.");
            if (GUI.Button(buttonUsed, "OK"))
            {
                intro2_complete = true;
            }
        }
        else if (show_end_message)
        {
            GUI.Box(boxUsed,
                "You have completed the level. Congratulations!");
            if (GUI.Button(buttonUsed, "OK"))
            {
                SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 3);
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
