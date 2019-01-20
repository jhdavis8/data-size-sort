using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * GameController: handles whether to progress the scene or not, other global checks
 */
public class GameController : MonoBehaviour
{
    public EndPoint[] endPoints;

    private Box somethingHeld;

    private void Start()
    {
        somethingHeld = null;
    }

    /*
    * Called once per frame. This checks if all EndPoints in the scene are filled and have the correct 
    * box in it.
    */
    void Update()
    {
        bool complete = true;
        for (int i = 0; i < endPoints.Length; i++)
        {
            //if(i == 3)
                //Debug.Log(!endPoints[i].isFull() || endPoints[i].tag != endPoints[i].CollidedTag());
            if (!endPoints[i].isFull() || endPoints[i].tag != endPoints[i].CollidedTag())
            {
                Debug.Log(endPoints[i].tag);
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
