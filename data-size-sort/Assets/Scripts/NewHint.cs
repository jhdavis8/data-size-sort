using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

/*
 * NewHint: Responsible for creating the different hints available to the player in level 2
 */ 
public class NewHint : MonoBehaviour
{
    public Sprite i_blank, i_bit1, i_bit2, i_bit3, i_bytes1, i_bytes2, i_bytes3,
            i_kb1, i_kb2, i_kb3, i_mb1, i_mb2, i_mb3, i_gb1, i_gb2, i_gb3,
            i_tb1, i_tb2, i_tb3, i_pb1, i_pb2, i_pb3, i_eb1, i_eb2, i_eb3,
            i_zb1, i_zb2, i_zb3;
    SpriteRenderer hintbutton;
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
     * Lets the hint box know which boxes are currently being used in the game
     * and sets the hints that can appear in game active.
     */
    public void SetupHint()
    {
        hintbutton = GameObject.Find("HintBox").GetComponent<SpriteRenderer>();

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
        if (GameObject.Find("Byte Box 1") != null)
        {
            bytes1 = GameObject.Find("Byte Box 1");
            s_bytes1 = bytes1.GetComponent<Box>();
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
            s_gb3 = gb3.GetComponent<Box>();
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
     * Called whenever the hint button is clicked. It will toggle which box will
     * show its hints or not
     */
    void OnMouseDown()
    {
        try
        {
            if (boxes.Count > 0)
            {
                foreach (Box b in boxes)
                {
                    if (b.CorrectDrop())
                    {
                        boxes.Remove(b);
                    }
                }

                System.Random rnd = new System.Random();
                int length = boxes.Count - 1;
                int num = rnd.Next(0, length);
                Box temp = boxes[num];

                /*
                 * Hint text output that has been randomly 
                 * selected
                 */
                if (hintbutton.sprite.Equals(i_blank))
                {
                    if (s_bit1 != null)
                    {
                        if (temp.Equals(s_bit1))
                        {
                            hintbutton.sprite = i_bit1;
                        }
                    }
                    if (s_bit2 != null)
                    {
                        if (temp.Equals(s_bit2))
                        {
                            hintbutton.sprite = i_bit2;
                        }
                    }
                    if (s_bit3 != null)
                    {
                        if (temp.Equals(s_bit3))
                        {
                            hintbutton.sprite = i_bit3;
                        }
                    }
                    else if (s_bytes1 != null)
                    {
                        if (temp.Equals(s_bytes1))
                        {
                            hintbutton.sprite = i_bytes1;
                        }
                    }
                    if (s_bytes2 != null)
                    {
                        if (temp.Equals(s_bytes2))
                        {
                            hintbutton.sprite = i_bytes2;
                        }
                    }
                    if (s_bytes3 != null)
                    {
                        if (temp.Equals(s_bytes3))
                        {
                            hintbutton.sprite = i_bytes3;
                        }
                    }
                    if (s_kb1 != null)
                    {
                        if (temp.Equals(s_kb1))
                        {
                            hintbutton.sprite = i_kb1;
                        }
                    }
                    if (s_kb2 != null)
                    {
                        if (temp.Equals(s_kb2))
                        {
                            hintbutton.sprite = i_kb2;
                        }
                    }
                    if (s_kb3 != null)
                    {
                        if (temp.Equals(s_kb3))
                        {
                            hintbutton.sprite = i_kb3;
                        }
                    }
                    if (s_mb1 != null)
                    {
                        if (temp.Equals(s_mb1))
                        {
                            hintbutton.sprite = i_mb1;
                        }
                    }
                    if (s_mb2 != null)
                    {
                        if (temp.Equals(s_mb2))
                        {
                            hintbutton.sprite = i_mb2;
                        }
                    }
                    if (s_mb3 != null)
                    {
                        if (temp.Equals(s_mb3))
                        {
                            hintbutton.sprite = i_mb3;
                        }
                    }
                    if (s_gb1 != null)
                    {
                        if (temp.Equals(s_gb1))
                        {
                            hintbutton.sprite = i_gb1;
                        }
                    }
                    if (s_gb2 != null)
                    {
                        if (temp.Equals(s_gb2))
                        {
                            hintbutton.sprite = i_gb2;
                        }
                    }
                    if (s_gb3 != null)
                    {
                        if (temp.Equals(s_gb3))
                        {
                            hintbutton.sprite = i_gb3;
                        }
                    }
                    if (s_tb1 != null)
                    {
                        if (temp.Equals(s_tb1))
                        {
                            hintbutton.sprite = i_tb1;
                        }
                    }
                    if (s_tb2 != null)
                    {
                        if (temp.Equals(s_tb2))
                        {
                            hintbutton.sprite = i_tb2;
                        }
                    }
                    if (s_tb3)
                    {
                        if (temp.Equals(s_tb3))
                        {
                            hintbutton.sprite = i_tb3;
                        }
                    }
                    if (s_pb1 != null)
                    {
                        if (temp.Equals(s_pb1))
                        {
                            hintbutton.sprite = i_pb1;
                        }
                    }
                    if (s_pb2 != null)
                    {
                        if (temp.Equals(s_pb2))
                        {
                            hintbutton.sprite = i_pb2;
                        }
                    }
                    if (s_pb3 != null)
                    {
                        if (temp.Equals(s_pb3))
                        {
                            hintbutton.sprite = i_pb3;
                        }
                    }
                    if (s_eb1 != null)
                    {
                        if (temp.Equals(s_eb1))
                        {
                            hintbutton.sprite = i_eb1;
                        }
                    }
                    if (s_eb2 != null)
                    {
                        if (temp.Equals(s_eb2))
                        {
                            hintbutton.sprite = i_eb2;
                        }
                    }
                    if (s_eb3 != null)
                    {
                        if (temp.Equals(s_eb3))
                        {
                            hintbutton.sprite = i_eb3;
                        }
                    }
                    if (s_zb1 != null)
                    {
                        if (temp.Equals(s_zb1))
                        {
                            hintbutton.sprite = i_zb1;
                        }
                    }
                    if (s_zb2 != null)
                    {
                        if (temp.Equals(s_zb2))
                        {
                            hintbutton.sprite = i_zb2;
                        }
                    }
                    if (s_zb3 != null)
                    {
                        if (temp.Equals(s_zb3))
                        {
                            hintbutton.sprite = i_zb3;
                        }
                    }
                }
                else
                {
                    hintbutton.sprite = i_blank;
                }
            }
        }

        catch (InvalidOperationException)
        {
            //Ignore exception
        }
    }
}