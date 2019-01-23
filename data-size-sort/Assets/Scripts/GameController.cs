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
    public bool complete;
    public GUIStyle boxStyle;
    public GUIStyle buttonStyle;
    private Box somethingHeld;
    private bool intro_complete = false;

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
        /*
        if (complete)
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1)%2);
        }
        */
    }
    /*
    void OnGUI()
    {
        if (!intro_complete) // && SceneManager.GetActiveScene().name == "Scene1")
        {
            GUI.Box(new Rect(100, 100, 600, 400),
                "This is the introduction and instructions.", boxStyle);
            if (GUI.Button(new Rect(350, 350, 100, 50), "OK", buttonStyle))
            {
                Debug.Log("You clicked ok");
                intro_complete = true;
            }
        }
    }
    */
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
}
