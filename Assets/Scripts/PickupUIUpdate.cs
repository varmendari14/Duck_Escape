using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupUIUpdate : MonoBehaviour
{
    public Text ducksText;
    public Text rubberText;
    public Text uglyText;
    public int numDucksAtStart;
    public GameEnding gameEnding;
    public StatTracker statTracker;
    private int ducksCount;

    public void RemoveDuckCount(Collision other) {
        if (other.gameObject.tag == "pickup") {
            Debug.Log("pickup tag detected");
	        ducksCount--;
            statTracker.decrementDucks();
            if (ducksCount <= 0) {
                ducksCount = 0;
                gameEnding.gameWon();
            }
            ducksText.text = "Ducks Remaining: " + ducksCount;
        }
        if (other.gameObject.tag == "rubber") {
            rubberText.color = new Color(0, 1, 0, 1);
            statTracker.setRubberDuck(true);
        }
        if (other.gameObject.tag == "ugly") {
            uglyText.color = new Color(0, 1, 0, 1);
            statTracker.setUglyDuck(true);
        }
    }

    // void OnCollisionEnter (Collision other) {
    //     RemoveDuckCount(other);
    // }

    void Start() {
        ducksCount = numDucksAtStart;
        statTracker.setDucks(ducksCount);
    	ducksText.text = "Ducks Remaining: " + ducksCount;
    }
}
