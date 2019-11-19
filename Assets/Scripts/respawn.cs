using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Transform Player;
    public Transform respawnPoint;
    public HealthBar healthBar;
    public int damageAmount = 5;

    void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
        healthBar.Damage(damageAmount);
    }
}
