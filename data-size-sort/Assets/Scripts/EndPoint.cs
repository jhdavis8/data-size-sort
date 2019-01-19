﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * EndPoint: where boxes are dropped by the player
 */
public class EndPoint : MonoBehaviour
{
    private Box box;
    private bool full;
    private string collidedName;

    private void Start()
    {
        collidedName = "";
        full = false;
    }

    /*
     * Checks for any collision with a collider. If a box is colliding, checks to see
     * if it has been dropped at the EndPoint.
     */
    private void OnTriggerStay2D(Collider2D collider)
    {
        box = collider.GetComponent<Box>(); //Charlie really got this it was cool man
        if (box != null && box.IsDropped())
        {
            full = true;
            collidedName = collider.tag;
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
    public string collidedTag()
    {
        return collidedName;
    }
}
