using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenuStuff : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public void ResumeButton() {
        // Debug.Log("Resume Button Pressed");
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0f;
        Time.timeScale = 1f;
    }

    public void RestartButton() {
        // Debug.Log("Restart Button Pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void ControlsButton() {
        //TODO - enable (and create) ControlsMenu(TBI) object
        //statTracker = GameObject.Find("ControlsMenu").Enable? or something similar
        //controls menu should already exist in title screen scene right?
    }

    public void QuitButton() {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }


}
