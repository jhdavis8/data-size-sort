using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    float distance = 10;
    bool collided = false;

    private Collider2D box;
    private Collider2D location;

    private GameObject obj;
    private GameObject startObj;

    private void Start()
    {
        obj = GameObject.FindWithTag("Box");
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        Vector3 locationVector = collider.gameObject.transform.position;
        obj.transform.position = locationVector;
        collided = true;
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        collided = false;
    }


    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,distance);
        Vector3 objPositoin = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPositoin;
    }

    private void OnMouseUp()
    {
        if (collided == false)
        {
            Debug.Log("Drag ended!");
            startObj = GameObject.FindWithTag("Start");
            Vector3 startPos = startObj.transform.position;
            transform.position = startPos;
        }
    }


}
