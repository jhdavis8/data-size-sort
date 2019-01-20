﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Box: the actual examples/sizes the player drags around
 */
public class Box : MonoBehaviour
{
    float distance = 10;
    private bool collided = false;          //Indicates if we should snap to the box or not
    public GameObject startPoint;           //We need this here so we can set a starting location inside unity (Aka a blank Box)
    public GameController controller;

    private Collider2D box;
    private Collider2D location;

    private GameObject obj;
    private GameObject startObj;

    private string collidingTag;
    private bool dropped = false;           //Used to tell if the box has been dropped by the user into a valid space
    private Collider2D collidedObject;      //Used to store the collider associated with the object the box has collided with

    private void Start()
    {
        collidingTag = "";
        collidedObject = null;
    }

    /*
     * Checks for collisions. If collided with an end point, store the tag and object
     * of the colliding object. Sets the transform position to the end point location
     */
    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.GetComponent<EndPoint>() != null)
        {
            //Sets location of object to location of object it has collided with
            Vector3 locationVector = collider.gameObject.transform.position;
            transform.position = locationVector;
            collided = true;
            collidingTag = collider.tag;
            collidedObject = collider;
        }
    }

    /*
     * Checks for if an object is removed from collider.
     */
    private void OnTriggerExit2D(Collider2D collider)
    {
        dropped = false;
        collided = false;
        collidedObject = null;
    }

    /*
     * Handles dragging with the mouse. Sets dropped to false
     */
    private void OnMouseDrag()
    {
        dropped = false;
        if (controller.whatIsHeld() == null || controller.whatIsHeld().Equals(this))
        {
            controller.setHeld(this);
            //Code sets object's position to match the location of the mouse
            Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;
        }
        
    }

    /*
     * Places the box if the mouse is released. Resets the box to start if it hasn't collided with an end point.
     * Sets dropped to true =. 
     */
    private void OnMouseUp()
    {
        dropped = true;
        Debug.Log("Mouse up");
        if (collided == false || (collidedObject != null && collidedObject.GetComponent<EndPoint>().isFull())) 
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
            
        }
        controller.setHeld(null);
    }

    /*
     * Accessor method for if the box has been snapped to a place.
     */
    public bool IsDropped()
    {
        return dropped;
    }

    /*
     * Checks if the object name is the same as this objects name
     */ 
    public bool Equals(Object obj)
    {
        return this.name.Equals(obj.name);
    }
}
