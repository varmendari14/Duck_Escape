using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FowlRun : MonoBehaviour
{
    public bool trig = false;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider c) {
        if(c.gameObject.tag == "Player"){
            trig = true;
        }
	
	}

	 void Start()
    {
        
    }
}
