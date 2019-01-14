using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    float distance = 10;

    private Collider2D box;
    private Collider2D location;


    private void Start()
    {
        GameObject box = GameObject.FindWithTag("Box");
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("Collision");
    }



    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,distance);
        Vector3 objPositoin = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPositoin;
    }

    

}
