using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour
{
    private bool full;

    private void Start()
    {
        full = false;
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        full = true;
    }

    public bool isFull()
    {
        return full;
    }
}
