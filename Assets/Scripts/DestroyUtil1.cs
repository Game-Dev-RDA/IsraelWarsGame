using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyUtil1 : MonoBehaviour
{
    public void DestroyHelper()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Middle1-2");
    }
}
