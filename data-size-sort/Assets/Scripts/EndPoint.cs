using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * EndPoint: where boxes are dropped by the player
 */
public class EndPoint : MonoBehaviour
{
    private Box box;
    private bool full;
    private string collidedName;    //Stores the object name of an object that is located at the end point
    private string collidedTag;

    private void Start()
    {
        collidedName = "";
        collidedTag = "";
        full = false;
    }

    /*
     * Checks for any collision with a collider. If a box is colliding, checks to see
     * if it has been dropped at the EndPoint.
     */
    private void OnTriggerStay2D(Collider2D collider)
    {
        box = collider.GetComponent<Box>();
        if (box != null && box.IsDropped())
        {
            full = true;
            collidedName = collider.name;
            collidedTag = collider.tag;
        }
    }

    /*
     * Called when an object leaves an end point. Checks if the object leaving is the same
     * as the object that was stored here. If it is, then the end point is emptied
     */
    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collidedName == collider.name)
        {
            full = false;
            collidedName = "";
            collidedTag = "";
        }
    }

    /*
     * Returns whether or not the EndPoint has a box dropped/snapped to it already
     */
    public bool isFull()
    {
        return full;
    }

    /*
     * Returns the name of the object that has collided with the endpoint 
     */
    public string CollidedTag()
    {
        return collidedTag;
    }
}
