using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yes_Button : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Changes back to original level 1 scene
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }
    }
}
