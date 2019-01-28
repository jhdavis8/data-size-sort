using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class No_Button : MonoBehaviour
{
    // Exits the game if pressed
    void OnMouseDown()
    {

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif     
    }
}
