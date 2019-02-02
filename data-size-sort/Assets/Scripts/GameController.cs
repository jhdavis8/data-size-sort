using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GameController: handles whether to progress the scene or not, check for completion, checking, displaying messages
 * and initializing levels
 */
public class GameController : MonoBehaviour
{
    public Box[] boxes;
    public Sprite[] answers;
    public int[] mapping;
    public GUISkin skin;
    public GUISkin bigSkin;
    private bool complete;
    private bool show_end_message = true;
    private Box somethingHeld;
    private bool intro1_complete = false;
    private bool intro2_complete = false;
    private Rect boxDefault = new Rect(550, 100, 750, 400);
    private Rect boxBig = new Rect(550 * 2, 100 * 2, 750 * 2, 400 * 2);
    private Rect buttonDefault = new Rect(875, 400, 100, 50);
    private Rect buttonBig = new Rect(875 * 2, 400 * 2, 100 * 2, 50 * 2);
    private Rect boxUsed;
    private Rect buttonUsed;
    public Check checkBox;
    public EndPoint[] endPoints;
    public NewHint hintBox;

    /*
     * Called at initialization, sets up the three random choices given to the player in level 2.
     */
    private void Start()
    {
        somethingHeld = null;
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            ThreeRandomCorrect();
            randomBoxes();
            hintBox.SetupHint();
        }
        else
        {
            hintBox = null;
        }
        
    }

    /*
    * Called once per frame. This checks if all Boxes in the scene are in the correct end position
    * If the check button is pressed, then it will set variables to signal the end of a level.
    */
    void Update()
    {
        complete = true;
        show_end_message = false;
        for (int i = 0; i < boxes.Length; i++)
        {
            if (!endPoints[i].Correct())
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
            }
            else
            {
                checkBox.setCheck();
            }
        }

    }
 
    /*
     * Colors each of the end points if it is correct. If correct, it is assigned the color green.
     * If incorrect, it is changed to red
     */ 
    private void ColorBoxes()
    {
        for (int i = 0; i < endPoints.Length; i++)
        {
            
            if (endPoints[i].Correct())
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
     * Controls the messages dispayed for the user. First, it checks the screen resolution to 
     * ensure it is correct visually for those in 4k and those that are not. Then it displays 
     * the correct message depending on which level the player is at
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
        //Debug.Log(SceneManager.GetActiveScene().name);
        if (!intro1_complete && SceneManager.GetActiveScene().name == "Level1")
        {
            GUI.Box(boxUsed,
                "Welcome to Data Size Sort. In this level, you need to order the various data size labels from smallest to largest." +
                "\n    -- You can pick up a label by clicking on it and dragging." +
                "\n    -- Release each box into the black end points to sort them. " +
                "\n    -- Click check when you have finished to see if you are correct" +
                "\n    -- Click hint to see a hint. " +
                "\n    -- Click reset to send all the labels to their starting positions.");
            if (GUI.Button(buttonUsed, "OK"))
            {
                intro1_complete = true;
            }
        }
        else if (!intro2_complete && SceneManager.GetActiveScene().name == "Level2")
        {
            GUI.Box(boxUsed,
                "Now, categorize these various real-world examples of data sizes by which data size you think they best fit under." +
                "\n    -- You can pick up a label by clicking on it and dragging." +
                "\n    -- Release each box into the black end points to categorize them. " +
                "\n    -- Click check when you have finished to see if you are correct." +
                "\n    -- Click return to send all the labels to their starting positions.");
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
     * Picks the three random correct boxes to place at level start. Guarantees that they are distinct.
     */
    private void ThreeRandomCorrect()
    {
        int[] numbers = new int[3];
        for(int i = 0;i < 3; i++)
        {
            numbers[i] = Random.Range(0, boxes.Length);
            for(int j = 0;j < i; j++)
            {
                if (numbers[j] == numbers[i])
                {
                    numbers[i] = Random.Range(0, boxes.Length);
                    j=0;
                }
            }
        }

        for(int i = 0;i < 3; i++)
        {
            int index = numbers[i];
            boxes[index].transform.position = endPoints[index].transform.position;
            endPoints[index].GetComponent<SpriteRenderer>().color = Color.green;
            endPoints[index].setStartBox(boxes[index]);
            boxes[index].setDropped(true);
            boxes[index].setCorrectPosition(true);
            boxes[index].setMovable(false);
        }

    }


    /*
     * Sets the value of somethingHeld, the flag indicating if the mouse has a box held right now.
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

    /*
     * Returns whether the level is complete
     */ 
    public bool isComplete()
    {
        return complete;
    }

    /*
     * Randomizes the sprites for the answers. Changes the name of the box accordingly
     */ 
    public void randomBoxes()
    {
        int randomNum = 0;
        int randomNum2 = 0;
        for (int i = 0; i < 9; i++)
        {
            string name = boxes[i * 2].name;
            name = name.Substring(0, name.Length - 1);
            randomNum = Random.Range(0, 2);
            randomNum2 = ((randomNum + 1) % 3);
            boxes[i*2 ].GetComponent<SpriteRenderer>().sprite = answers[i*3 + randomNum];
            boxes[i*2 + 1].GetComponent<SpriteRenderer>().sprite = answers[i*3 + randomNum2];

            boxes[i * 2].name = name + (randomNum+1);
            boxes[i * 2+1].name = name + (randomNum2+1);
            


        }
    }

}
