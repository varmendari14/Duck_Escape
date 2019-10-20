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
                mainText.text = "You lucky duck, you won.";
                newLevelText.text = "Next Level";
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
