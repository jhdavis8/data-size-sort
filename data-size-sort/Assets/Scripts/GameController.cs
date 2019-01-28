using System.Collections;
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
    private bool intro_complete = false;
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
        if (!intro_complete) // && SceneManager.GetActiveScene().name == "Scene1")
        {
            GUI.Box(new Rect(100, 100, 600, 400),
                "This is the introduction and instructions.");
            if (GUI.Button(new Rect(350, 350, 100, 50), "OK"))
            {
                Debug.Log("You clicked ok");
                intro_complete = true;
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
