using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupUIUpdate : MonoBehaviour
{
    public Text ducksText;
    private int ducksCount;

    /*
    void onTriggerEnter(Collider other) {
	    duckCount--;
    }
    */

    void Start() {
    	ducksText.text = "Ducks Remaining: " + ducksCount;
    }
}
