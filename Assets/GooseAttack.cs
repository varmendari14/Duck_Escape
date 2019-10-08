using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseAttack : MonoBehaviour
{
	public bool triggered = false;

	private void OnTriggerEnter(Collider c) {
        if(c.gameObject.tag == "Player"){
            triggered = true;
        }
	
	}

	private void OnTriggerExit(Collider c) {
		 if(c.gameObject.tag == "Player"){
            triggered = false;
        }
	}
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
