﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    float distance = 10;

    private Collider2D box;
    private Collider2D location;

    private GameObject obj;
    private void Start()
    {
        obj = GameObject.FindWithTag("Box");
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        Vector3 locationVector = collider.gameObject.transform.position;
        obj.transform.position = locationVector;
    }



    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y,distance);
        Vector3 objPositoin = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = objPositoin;
    }

    

}
