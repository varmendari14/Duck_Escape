using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class GooseAI : MonoBehaviour
{
	UnityEngine.AI.NavMeshAgent mesh;
	Animator anim;
	public GameObject[] waypoints = new GameObject[4];
	int currWaypoint = 0;
	NavMeshAgent nav;
	Vector3 dir;
	float dot;
	public GameObject collider;
	GooseAttack goose;
	public GameObject player;
	Vector3 relativePos;

	public AudioClip damageAudio;
	private bool hasPlayed = false;

	private void setNextWaypoint() {
		if (waypoints.Length == 0) {
			return;
		}
 		if (currWaypoint < waypoints.Length ) {
			nav.SetDestination(waypoints[currWaypoint].transform.position);
			relativePos = waypoints[currWaypoint].transform.position - transform.position;
 			transform.rotation = Quaternion.LookRotation (relativePos);

			currWaypoint++;
		} else if (currWaypoint >= waypoints.Length ) {
			currWaypoint = 0;
			nav.SetDestination(waypoints[currWaypoint].transform.position);
			relativePos = waypoints[currWaypoint].transform.position - transform.position;
 			transform.rotation = Quaternion.LookRotation (relativePos);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
    	goose = collider.GetComponent<GooseAttack>();
    	nav = GetComponent<NavMeshAgent>();
    	anim = GetComponent<Animator>();
    	anim.SetBool("Attack",false);
        setNextWaypoint();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	//transform.rotation = Quaternion.Euler(0, transform.rotation.y, 0);

    	if (transform.position.y <= 0.8820) {
    		nav.enabled = true;
    	}

    	if (goose.triggered == true) {
			if (!hasPlayed) {
				AudioSource.PlayClipAtPoint(damageAudio, transform.position);
				hasPlayed = true;
			}
    		anim.SetBool("Attack",true);
    	    //nav.SetDestination(player.transform.position); USED to attack player

    	} else {
			hasPlayed = false;
    		anim.SetBool("Attack",false);
    	}

    	if (goose.obtrig == true) {
    		nav.enabled = false;
    		GetComponent<Rigidbody>().AddForce(0f, 20f, 0f, ForceMode.Impulse);
    	}
       if (!nav.pathPending && nav.remainingDistance < 1f) {
        	setNextWaypoint();
        }
    }
}
