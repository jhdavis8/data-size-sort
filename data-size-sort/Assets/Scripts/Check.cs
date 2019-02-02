using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Check: Controls the level check button to see if it has been pressed
 */ 
public class Check : MonoBehaviour
{
    public GameController gameController;
    private bool checkPressed = false;
 
    /*
     * Update is called once per frame. Sees if the check button is clicked and then sets 
     * check pressed to true
     */ 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.tag == "Check")
            {
                checkPressed = true;

            }
        }
    }

    /*
     * returns the value of checkPressed
     */ 
    public bool check()
    {
        return checkPressed;
    }

    /*
     * Resets the check button boolean to be false
     */ 
    public void setCheck()
    {
        checkPressed = false;
    }
}
