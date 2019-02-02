using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public Sprite kb1, kb2, mb1, mb2, gb1, gb2, tb1, tb2, pb1, pb2, eb1, eb2, zb1, zb2;
    SpriteRenderer kb, mb, gb, tb, pb, eb, zb;
    /*
     * Called at the start of the scene
     */ 
    void Start()
    {

        kb = GameObject.Find("Kilobyte").GetComponent<SpriteRenderer>();
        mb = GameObject.Find("Megabyte").GetComponent<SpriteRenderer>();
        gb = GameObject.Find("Gigabyte").GetComponent<SpriteRenderer>();
        tb = GameObject.Find("Terabyte").GetComponent<SpriteRenderer>();
        pb = GameObject.Find("Petabyte").GetComponent<SpriteRenderer>();
        eb = GameObject.Find("Exabyte").GetComponent<SpriteRenderer>();
        zb = GameObject.Find("Zettabyte").GetComponent<SpriteRenderer>();
    }

    /*
     * Called whenever the hint button is clicked. It will toggle whether the boxes
     * show their hints or not
     */ 
    void OnMouseDown()
    {

        if (kb.sprite.Equals(kb1))
        {
            kb.sprite = kb2;
            mb.sprite = mb2;
            gb.sprite = gb2;
            tb.sprite = tb2;
            pb.sprite = pb2;
            eb.sprite = eb2;
            zb.sprite = zb2;
        }
        else
        {

            kb.sprite = kb1;
            mb.sprite = mb1;
            gb.sprite = gb1;
            tb.sprite = tb1;
            pb.sprite = pb1;
            eb.sprite = eb1;
            zb.sprite = zb1;
        }
    }

}


