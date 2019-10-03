using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCountdown : MonoBehaviour
{
    public Text timeText;
    public int countdown;


    void Start() {
    	//countdown = 60; //set starting time here, i just did 60 by default
    }

    void Update() {
        //time countdown here. every second passing, do countdown--;
        timeText.text = "Time Left: " + countdown;
    }
}
