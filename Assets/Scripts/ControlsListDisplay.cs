using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsListDisplay : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject controlsMenu;

    public void BacktoMenu()
    {
      mainMenu.SetActive(true);
      controlsMenu.SetActive(false);
    }

    public void showControls()
    {
      mainMenu.SetActive(false);
      controlsMenu.SetActive(true);
    }
}
