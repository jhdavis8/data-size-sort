using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour
{
    public GameController gameController;
    private bool checkPressed = false;
 
    // Update is called once per frame
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

    public bool check()
    {
        return checkPressed;
    }

    public void setCheck()
    {
        checkPressed = false;
    }
}
