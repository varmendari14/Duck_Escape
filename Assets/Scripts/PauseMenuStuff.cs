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
        // Will load whatever current level is loaded
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void QuitButton() {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

}
