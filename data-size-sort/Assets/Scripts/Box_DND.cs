using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;


public class Box_DND : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler


{
    int initialPointerId;

    void Start()
    {
        initialPointerId = int.MaxValue;
    }

    void OnBeginDrag(PointerEventData eventData)
    {
        if (initialPointerId == int.MaxValue)
        {
            initialPointerId = eventData.pointerId;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (initialPointerId == eventData.pointerId)
        {
            initialPointerId = int.MaxValue;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (initialPointerId == eventData.pointerId)
        {
            // DO WHATEVER YOU WANNA DO DURING DRAGGING HERE
        }
    }
}