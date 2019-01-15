using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private Box box;
    private bool full;

    private void Start()
    {
        full = false;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        box = collider.GetComponent<Box>();
        if (box != null && box.IsDropped())
        {
            full = true;
        }
    }

    public bool isFull()
    {
        return full;
    }
}
