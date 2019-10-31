using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsDisplay : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditsMenu;

    public void BacktoMenu()
    {
      mainMenu.SetActive(true);
      creditsMenu.SetActive(false);
    }

    public void showCredits()
    {
      mainMenu.SetActive(false);
      creditsMenu.SetActive(true);
    }
}
