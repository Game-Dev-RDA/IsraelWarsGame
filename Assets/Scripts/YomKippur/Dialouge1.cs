using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialouge1 : MonoBehaviour
{
    // Feilds
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public Canvas dialogCanvas;
    public GameObject continueButton;
    [SerializeField] string scene;

    /** on start - start typing text (if there is any) **/
    private void Start()
    {
        StartCoroutine(Type());
    }

    private void Update()
    {
        // keep executing dialog text until text reach to the end
        if (textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    /**This function is about the logic of how to present text in Text dialog**/
    IEnumerator Type()
    {
        // hide continue button as long as text section dosn't finish
        continueButton.SetActive(false);
        // go over each letter and make it appear to screen
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    /**This function is about the logic of how to present next sentence in Text dialog**/
    public void NextSentence()
    {
        //check if there is no more sentences to be shown on text dialog.
        //if there is start typing the next sentence
        //if not hide continue button and text dialog
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            SceneManager.LoadScene(scene);
            continueButton.SetActive(false);
            dialogCanvas.enabled = false;
        }
    }
}
