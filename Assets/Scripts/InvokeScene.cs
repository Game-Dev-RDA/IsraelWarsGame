using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InvokeScene : MonoBehaviour
{
    public float delay = 5f;
    private bool hasMoved = false; // Flag to track if the scene has already been loaded and moved to

    public void Start()
    {
        if (!hasMoved)
        {
            hasMoved = true; // Set the flag to indicate that the scene has been loaded and moved to
            Invoke("DelayedLoadScene", delay); // Delay the loading of the scene by 5 seconds
        }
    }

    private void DelayedLoadScene()
    {
        SceneManager.LoadScene("Middle1-2"); // Load the scene
    }
}
