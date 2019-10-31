using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuHandler : MonoBehaviour
{
    public string currentSceneName;
    public string nextSceneName;

    public void Quit()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void RestartButton()
    {
        Debug.Log("Restart Button Pressed");
        UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
        Time.timeScale = 1f;
    }

    public void NextButton()
    {
        Debug.Log("Next Button Pressed");
        // TODO: Uncomment when level 2 is added
        // UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
        // Time.timeScale = 1f;
    }
}
