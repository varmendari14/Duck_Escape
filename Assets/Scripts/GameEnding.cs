using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public StatTracker statTracker;
    public Text mainText;
    public Text newLevelText;
    public GameObject nextButton;
    public GameObject restartButton;

    public CanvasGroup canvasGroup;

    void Awake() {
        canvasGroup = this.gameObject.transform.GetChild(0).GetComponent<CanvasGroup>();
        Debug.Log(canvasGroup);
        if (canvasGroup == null) {
            Debug.LogError("canvasGroup component not found.");
        }
    }

    void Start() {
        canvasGroup = this.gameObject.transform.GetChild(0).GetComponent<CanvasGroup>();
        Debug.Log(canvasGroup);
        canvasGroup.alpha = 0;
    }

    void Update()
    {
        statTracker = GameObject.Find("GameStats").GetComponent<StatTracker>();
        
            if (statTracker.didLose)
            {
                mainText.text = "You let the foul fowl best you.";
                newLevelText.text = "Restart Level";
            } else
            {
                mainText.text = "You lucky duck, you won. Your birds are swimming happily in their pond.";
                newLevelText.text = "Next Level";
            }
            if (statTracker.rubberDuck) {
                mainText.text += " \nThe rubber duck floats in the pond.";
            }
            if (statTracker.uglyDuck) {
                mainText.text += " \nThe ugly duckling dances in the sand.";
            }
        
    }

    public void gameWon()
	{
        Debug.Log("Game won");
        statTracker.setDidLose(false);
        nextButton.SetActive(true);
        restartButton.SetActive(false);
        makeMenu();
	}

    public void gameLost()
	{
        Debug.Log("Game Lost");
        statTracker.setDidLose(true);
        nextButton.SetActive(false);
        restartButton.SetActive(true);
        makeMenu();
	}

    public void makeMenu() {
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        Time.timeScale = 0f;
    }

}
