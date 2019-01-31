using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHint : MonoBehaviour
{
    GameObject bit, bit1, bit2, bit3, bytes, bytes1, bytes2, bytes3, 
            kb, kb1, kb2, kb3, mb, mb1, mb2, mb3, gb, gb1, gb2, gb3, 
            tb, tb1, tb2, tb3, pb, pb1, pb2, pb3, eb, eb1, eb2, eb3,
            zb, zb1, zb2, zb3;
    Box scriptInstance = null;
    /*
     * Called at the start of the scene
     */
    void Start()
    {

        bit = GameObject.Find("Bit Box 1");
        scriptInstance = bit.GetComponent<Box>();
    }

    /*
     * Called whenever the hint button is clicked. It will toggle whether the boxes
     * show their hints or not
     */
    void OnMouseOver()
    {
        if (scriptInstance.CorrectDrop())
        {
            Debug.Log("yes");
        }
        
    }
}