using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuStuff : MonoBehaviour
{
    public void ResumeButton() {
        //TODO - close pause menu
    }

    public void RestartButton() {
        //TODO - reload current scene
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
