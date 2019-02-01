using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewHint : MonoBehaviour
{
    GameObject bit1, bit2, bit3, bytes1, bytes2, bytes3, 
            kb1, kb2, kb3, mb1, mb2, mb3, gb1, gb2, gb3, 
            tb1, tb2, tb3, pb1, pb2, pb3, eb1, eb2, eb3,
            zb1, zb2, zb3;
    Box s_bit1 = null;
    Box s_bit2 = null;
    Box s_bit3 = null;
    Box s_bytes1 = null;
    Box s_bytes2 = null;
    Box s_bytes3 = null;
    Box s_kb1 = null;
    Box s_kb2 = null;
    Box s_kb3 = null;
    Box s_mb1 = null;
    Box s_mb2 = null;
    Box s_mb3 = null;
    Box s_gb1 = null;
    Box s_gb2 = null;
    Box s_gb3 = null;
    Box s_tb1 = null;
    Box s_tb2 = null;
    Box s_tb3 = null;
    Box s_pb1 = null;
    Box s_pb2 = null;
    Box s_pb3 = null;
    Box s_eb1 = null;
    Box s_eb2 = null;
    Box s_eb3 = null;
    Box s_zb1 = null;
    Box s_zb2 = null;
    Box s_zb3 = null;

    List<Box> boxes = new List<Box>();
    /*
     * Called at the start of the scene
     */
    void Start()
    {
        if (GameObject.Find("Bit Box 1") != null) {
            bit1 = GameObject.Find("Bit Box 1");
            s_bit1 = bit1.GetComponent<Box>();
            boxes.Add(s_bit1);
        }
        if (GameObject.Find("Bit Box 2") != null)
        {
            bit2 = GameObject.Find("Bit Box 2");
            s_bit2 = bit2.GetComponent<Box>();
            boxes.Add(s_bit2);
        }
        if (GameObject.Find("Bit Box 3") != null)
        {
            bit3 = GameObject.Find("Bit Box 3");
            s_bit3 = bit3.GetComponent<Box>();
            boxes.Add(s_bit3);
        }
        if (GameObject.Find("Byte Box 3") != null)
        {
            bytes1 = GameObject.Find("Byte Box 1");
            s_bytes1 = bit1.GetComponent<Box>();
            boxes.Add(s_bytes1);
        }
        if (GameObject.Find("Byte Box 2") != null)
        {
            bytes2 = GameObject.Find("Byte Box 2");
            s_bytes2 = bytes2.GetComponent<Box>();
            boxes.Add(s_bytes2);
        }

        if (GameObject.Find("Byte Box 3") != null)
        {
            bytes3 = GameObject.Find("Byte Box 3");
            s_bytes3 = bytes3.GetComponent<Box>();
            boxes.Add(s_bytes3);
        }
        if (GameObject.Find("KB Box 1") != null)
        {
            kb1 = GameObject.Find("KB Box 1");
            s_kb1 = kb1.GetComponent<Box>();
            boxes.Add(s_kb1);
        }
        if (GameObject.Find("KB Box 2") != null)
        {
            kb2 = GameObject.Find("KB Box 2");
            s_kb2 = kb2.GetComponent<Box>();
            boxes.Add(s_kb2);
        }
        if (GameObject.Find("KB Box 3") != null)
        {
            kb3 = GameObject.Find("KB Box 3");
            s_kb3 = kb3.GetComponent<Box>();
            boxes.Add(s_kb3);
        }
        if (GameObject.Find("MB Box 1") != null)
        {
            mb1 = GameObject.Find("MB Box 1");
            s_mb1 = mb1.GetComponent<Box>();
            boxes.Add(s_mb1);
        }
        if (GameObject.Find("MB Box 2") != null)
        {
            mb2 = GameObject.Find("MB Box 2");
            s_mb2 = mb2.GetComponent<Box>();
            boxes.Add(s_mb2);
        }
        if (GameObject.Find("MB Box 3") != null)
        {
            mb3 = GameObject.Find("MB Box 3");
            s_mb3 = mb3.GetComponent<Box>();
            boxes.Add(s_mb3);
        }
        if (GameObject.Find("GB Box 1") != null)
        {
            gb1 = GameObject.Find("GB Box 1");
            s_gb1 = gb1.GetComponent<Box>();
            boxes.Add(s_gb1);
        }
        if (GameObject.Find("GB Box 2") != null)
        {
            gb2 = GameObject.Find("GB Box 2");
            s_gb2 = gb2.GetComponent<Box>();
            boxes.Add(s_gb2);
        }
        if (GameObject.Find("GB Box 3") != null)
        {
            gb3 = GameObject.Find("GB Box 3");
            s_tb3 = tb3.GetComponent<Box>();
            boxes.Add(s_gb3);
        }
        if (GameObject.Find("TB Box 1") != null)
        {
            tb1 = GameObject.Find("TB Box 1");
            s_tb1 = tb1.GetComponent<Box>();
            boxes.Add(s_tb1);
        }
        if (GameObject.Find("TB Box 2") != null)
        {
            tb2 = GameObject.Find("TB Box 2");
            s_tb2 = tb2.GetComponent<Box>();
            boxes.Add(s_tb2);
        }
        if (GameObject.Find("TB Box 3") != null)
        {
            tb3 = GameObject.Find("TB Box 3");
            s_tb3 = tb3.GetComponent<Box>();
            boxes.Add(s_tb3);
        }
        if (GameObject.Find("PB Box 1") != null)
        {
            pb1 = GameObject.Find("PB Box 1");
            s_pb1 = pb1.GetComponent<Box>();
            boxes.Add(s_pb1);
        }
        if (GameObject.Find("PB Box 2") != null)
        {
            pb2 = GameObject.Find("PB Box 2");
            s_pb2 = pb2.GetComponent<Box>();
            boxes.Add(s_pb2);
        }
        if (GameObject.Find("PB Box 3") != null)
        {
            pb3 = GameObject.Find("PB Box 3");
            s_pb3 = pb3.GetComponent<Box>();
            boxes.Add(s_pb3);
        }
        if (GameObject.Find("EB Box 1") != null)
        {
            eb1 = GameObject.Find("EB Box 1");
            s_eb1 = eb1.GetComponent<Box>();
            boxes.Add(s_eb1);
        }
        if (GameObject.Find("EB Box 2") != null)
        {
            eb2 = GameObject.Find("EB Box 2");
            s_eb2 = eb2.GetComponent<Box>();
            boxes.Add(s_eb2);
        }
        if (GameObject.Find("EB Box 3") != null)
        {
            eb3 = GameObject.Find("EB Box 3");
            s_eb3 = eb3.GetComponent<Box>();
            boxes.Add(s_eb3);
        }
        if (GameObject.Find("ZB Box 1") != null)
        {
            zb1 = GameObject.Find("ZB Box 1");
            s_zb1 = zb1.GetComponent<Box>();
            boxes.Add(s_zb1);
        }
        if (GameObject.Find("ZB Box 2") != null)
        {
            zb2 = GameObject.Find("ZB Box 2");
            s_zb2 = zb2.GetComponent<Box>();
            boxes.Add(s_zb2);
        }
        if (GameObject.Find("ZB Box 3") != null)
        {
            zb3 = GameObject.Find("ZB Box 3");
            s_zb3 = zb3.GetComponent<Box>();
            boxes.Add(s_zb3);
        }
    }

    /*
     * Called whenever the hint button is clicked. It will toggle whether the boxes
     * show their hints or not
     */
    void OnMouseOver()
    {
        if (s_bit1.CorrectDrop())
        {
            int count = boxes.Count;
            Debug.Log(count);
        }
        
    }
}