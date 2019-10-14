using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Text healthText;
    public int maxHealth;
    private float currHealth;


    void Start() {
    	currHealth = maxHealth;
      healthText.color = new Color(1, 0, 0, 1);
      healthText.text = "Health: " + currHealth.ToString("0");
    }

    void Damage(int points) {
      currHealth -= points;
      healthText.text = "Health: " + currHealth.ToString("0");
    }
}
