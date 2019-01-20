using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset_Button : MonoBehaviour
{

    /*
     * Called every frame. Checks if mouse has been pressed and if so checks 
     * if reset button object was clicked. If the reset button was presed, the 
     * level is reset and the active scene is reloaded.
     */
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.tag == "Reset")
            {
                Debug.Log("Level Reset");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    
}
