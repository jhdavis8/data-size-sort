using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Check : MonoBehaviour
{
    public GameController gameController;
    private bool myBool;
    // Start is called before the first frame update
    void Start()
    {
        myBool = gameController.complete; 
    }

    // Update is called once per frame
    void Update()
    {
        myBool = gameController.complete;
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null && hit.collider.tag == "Check")
            {
                if (myBool == true)
                {
                    Debug.Log("Correct!");
                    SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1) % 2);
                }
                else
                {
                    Debug.Log("Incorrect!");
                }

            }
        }
    }
}
