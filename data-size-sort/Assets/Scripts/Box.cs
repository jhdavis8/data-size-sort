using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Box: the actual examples/sizes the player drags around
 */
public class Box : MonoBehaviour
{
    float distance = 10;
    public bool collided = false;          //Used to tell if we should snap to the box or not
    public GameObject startPoint;   //We need this here so we can set a starting location inside unity (Aka a blank Box)

    private Collider2D box;
    private Collider2D location;

    private GameObject obj;
    private GameObject startObj;

    private string collidingTag;
    private bool dropped = false; //Used to tell if the box has been dropped by the user into a valid space

    private void Start()
    {
        collidingTag = "";
    }

    //FIX ME
    /*
     * Checks for collisions. If collided with a non-starting location, store the tag
     * of the colliding object. Sets the transform position to whatever it collides with??? (fix)
     */
    private void OnTriggerStay2D(Collider2D collider)
    {
        //Sets location of object to location of object it has collided with
        Vector3 locationVector = collider.gameObject.transform.position;
        transform.position = locationVector;
        if (collider.tag != ("Start")) //Change to check to see if collider is an EndPoint
        {
            collided = true;
            collidingTag = collider.tag;
        }
    }

    /*
     * Checks for if an object is removed from collider.
     */
    private void OnTriggerExit2D(Collider2D collider)
    {
        collided = false;
    }

    /*
     * Handles dragging with the mouse
     */
    private void OnMouseDrag()
    {
        //Code sets object's position to match the location of the mouse
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,distance);
        Vector3 objPositoin = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPositoin;
    }

    /*
     * Places the box if the mouse is released. Resets the box to start if it hasn't collided with anything.
     */
    private void OnMouseUp()
    {
        if (collided == false)
        {   
            Vector3 startPos = startPoint.transform.position;
            transform.position = startPos;
        }
        else
        {
            if (collidingTag == this.tag)
            {
                Debug.Log("Correct");
            }
            else
            {
                Debug.Log("Wrong");
            }
            dropped = true;
        }
    }

    /*
     * Accessor method for if the box has been snapped to a place.
     */
    public bool IsDropped()
    {
        return dropped;
    }
}
