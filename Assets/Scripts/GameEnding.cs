using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEnding : MonoBehaviour
{
    public string sceneName = "LevelEndScene";
    public StatTracker statTracker;
    public Text mainText;
    public Text newLevelText;

    private void Start()
    {
        statTracker = GameObject.Find("GameStats").GetComponent<StatTracker>();
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().name == sceneName)
        {
            if (statTracker.didLose)
            {
                mainText.text = "You let the foul fowel best you.";
                newLevelText.text = "Restart";
            } else
            {
                mainText.text = "You lucky duck, you won. Your birds are swimming happily in their pond.";
                newLevelText.text = "Next Level";
            }
            if (statTracker.rubberDuck) {
                mainText.text += " The rubber duck floats in the pond.";
            }
            if (statTracker.uglyDuck) {
                mainText.text += " The ugly duckling dances in the sand.";
            }
        }
    }

    public void gameWon()
	{
        Debug.Log("Game won");
        statTracker.setDidLose(false);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
	}

    public void gameLost()
	{
        Debug.Log("Game Lost");
        statTracker.setDidLose(true);
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
	}

}
