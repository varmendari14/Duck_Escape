using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooseAttack : MonoBehaviour
{
	public bool triggered = false;
    public bool obtrig = false;

	private void OnTriggerEnter(Collider c) {
        if(c.gameObject.tag == "Player"){
            triggered = true;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
