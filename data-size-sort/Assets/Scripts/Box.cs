using System.Collections;
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
    private bool correctPlace = false;
    private EndPoint endpoint;
    private EndPoint finalEndpoint;
    private Vector3 startPos;

    private bool movable = true;

    private void Start()
    {
        startPos = transform.position;
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
            endpoint = collider.GetComponent<EndPoint>();
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
     * Handles dragging with the mouse. Sets dropped to false. Only can drag if
     * there is nothing else being dragged
     */
    private void OnMouseDrag()
    {
        this.GetComponent<SpriteRenderer>().sortingOrder = 2;
        dropped = false;
        if ((controller.whatIsHeld() == null || controller.whatIsHeld().Equals(this)) && movable)
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
     * Sets dropped to true. 
     */
    private void OnMouseUp()
    {
        dropped = true;
        finalEndpoint = endpoint;
        if (collided == false || (collidedObject != null && collidedObject.GetComponent<EndPoint>().isFull()))
        {
            transform.position = startPos;
            correctPlace = false;
        }
        else
        {
            if (collidingTag == this.tag)
            {
                correctPlace = true;
            }
            else
            {
                correctPlace = false;
            }

        }
        controller.setHeld(null);
        this.GetComponent<SpriteRenderer>().sortingOrder = 1;
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

    /*
     * Returns whether the box has been placed in the correct position or not
     */
    public bool CorrectDrop()
    {
        return correctPlace;
    }

    /*
     * returns the endpoint that it has encounterd
     */
    public EndPoint EndPoint()
    {
        return finalEndpoint;
    }

    /*
     * Setter for dropped, the flag for if the box has been dropped in an endpoint
     */
    public void setDropped(bool drop)
    {
        dropped = drop;
    } 

    public void setMovable(bool move)
    {
        movable = move;
    }
}

