using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yes_Button : MonoBehaviour
{

    // Changes back to original level 1 scene
    void OnMouseDown()
    {  
            SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
