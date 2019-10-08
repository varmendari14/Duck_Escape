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
    private int ducksCount;

    void OnCollisionEnter (Collision other) {
        if (other.gameObject.tag == "pickup") {
            Debug.Log("pickup tag detected");
	        ducksCount--;
            if (ducksCount < 0) {
                ducksCount = 0;
            }
            ducksText.text = "Ducks Remaining: " + ducksCount;
        }
        if (other.gameObject.tag == "rubberduck") {
            rubberText.color = new Color(0, 1, 0, 1);
        }
        if (other.gameObject.tag == "uglyduck") {
            uglyText.color = new Color(0, 1, 0, 1);
        }
    }

    void Start() {
        ducksCount = numDucksAtStart;
    	ducksText.text = "Ducks Remaining: " + ducksCount;
    }

}
