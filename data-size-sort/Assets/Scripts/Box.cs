using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    float distance = 10;
    bool collided = false;          //Used to tell if we should snap to the box or not
    public GameObject startPoint;   //We need this here so we can set a starting location inside unity (Aka a blank Box)

    private Collider2D box;
    private Collider2D location;

    private GameObject obj;
    private GameObject startObj;

    private void Start()
    {

    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        //Sets location of object to location of object it has collided with
        Vector3 locationVector = collider.gameObject.transform.position;
        transform.position = locationVector;
        collided = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        collided = false;
    }


    private void OnMouseDrag()
    {
        //Code sets object's position to match the location of the mouse
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,distance);
        Vector3 objPositoin = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPositoin;
    }

    private void OnMouseUp()
    {
        if (collided == false)
        {   
            Vector3 startPos = startPoint.transform.position;
            transform.position = startPos;
        }
    }


}
