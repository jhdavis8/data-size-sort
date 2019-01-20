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

    private Box somethingHeld;

    private void Start()
    {
        somethingHeld = null;
    }

    /*
    * Called once per frame. This checks if all Boxes in the scene are in the correct end position 
    */
    void Update()
    {
        bool complete = true;
        for (int i = 0; i < boxes.Length; i++)
        {
            if (!boxes[i].CorrectDrop())
            {
                complete = false;
            }
        }
        if (complete)
        {
            SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex+1)%2);
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
}
