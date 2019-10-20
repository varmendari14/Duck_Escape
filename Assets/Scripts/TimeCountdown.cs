using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountdown : MonoBehaviour
{
    public Text timeText;
    public int startTime;
    public GameEnding gameEnding;
    private float currTime;


    void Start() {
    	currTime = startTime;
    }

    void Update() {
        currTime -= 1 * Time.deltaTime;
        if (currTime < 30) {
            timeText.color = new Color(1f, .8f, 0, 1);
        }
        if (currTime < 10) {
            timeText.color = new Color(1, 0, 0, 1);
        }
        if (currTime < 0) {
            currTime = 0;
            gameEnding.gameLost();
        }
        timeText.text = "Time Left: " + currTime.ToString("0");
    }
}
