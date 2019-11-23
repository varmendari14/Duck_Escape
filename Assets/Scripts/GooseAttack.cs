using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseAttack : MonoBehaviour
{
	public bool triggered = false;
    public bool obtrig = false;
    public int damagePoints = 5;
    public float damageDist = 5f;
    public HealthBar healthBar;
    public float attackTimeDelta = 2f;

    private float lastAttackTime;

	private void OnTriggerEnter(Collider c) {
        if(c.gameObject.tag == "Player"){
            triggered = true;
            
            if (Vector3.Distance(c.gameObject.transform.position, this.gameObject.transform.position) < damageDist
                && Time.time - lastAttackTime > attackTimeDelta)
            {
                healthBar.Damage(damagePoints);
                lastAttackTime = Time.time;
            }
        }

        if(c.gameObject.tag == "Object"){
            obtrig = true;
        }
	
	}

	private void OnTriggerExit(Collider c) {
		 if(c.gameObject.tag == "Player"){
            triggered = false;
        }

        if(c.gameObject.tag == "Object"){
            obtrig = false;
        }
	}
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
        obtrig = false;
        lastAttackTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
