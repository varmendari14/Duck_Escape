﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuHandler : MonoBehaviour
{
    public string currentSceneName;
    public string nextSceneName;
    private bool didLose = false;
    private StatTracker st;

    public void Start() {
        st = GameObject.Find("GameStats").GetComponent<StatTracker>();
        didLose = st.didLose;
    }

    public void Quit()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void RestartButton()
    {
        Debug.Log("Restart Button Pressed");
        if (didLose) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(currentSceneName);
        } else {
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
        }
        Time.timeScale = 1f;
    }

    public void NextButton()
    {
        Debug.Log("Restart Button Pressed");
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
        Time.timeScale = 1f;
    }
}
