using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    float distance = 10;

    private Collider2D box;
    private Collider2D location;
    private float x;
    private float y;
    private float xSize;
    private float ySize;


    private void Start()
    {
        GameObject box = GameObject.FindWithTag("Box");
        x = box.transform.position.x;
        y = box.transform.position.y;
        xSize = box.GetComponent<Collider2D>().bounds.size.x;
        ySize = box.GetComponent<Collider2D>().bounds.size.y;

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
