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
	public GameObject[] waypoints = new GameObject[6];
	int currWaypoint = 0;
	NavMeshAgent nav;
	Vector3 dir;
	float dot;
	public GameObject collider;
	GooseAttack goose;
	public GameObject player;


	private void setNextWaypoint() {
		if (waypoints.Length == 0) {
			return;
		}
 		if (currWaypoint < waypoints.Length ) {
			nav.SetDestination(waypoints[currWaypoint].transform.position);
			currWaypoint++;
		} else if (currWaypoint >= waypoints.Length ) {
			currWaypoint = 0;
			nav.SetDestination(waypoints[currWaypoint].transform.position);
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
    void Update()
    {
    	if (goose.triggered == true) {
    		anim.SetBool("Attack",true);
    		nav.SetDestination(player.transform.position);
    	} else {
    		anim.SetBool("Attack",false);
    	}
    	/*Vector3 forward = transform.forward *10;
    	Debug.DrawRay(this.transform.position, forward, Color.red);
    	dir = (this.transform.position - player.transform.position).normalized;
    	dot = Vector3.Dot(dir, this.transform.forward);
    	Debug.Log(dot);
    	if (dot > 0 && Vector3.Distance(player.transform.position, this.transform.position) < 10f) {
    		Debug.Log("Attack");
    	}*/
    	//anim.SetFloat("vely", nav.velocity.magnitude / nav.speed);
       if (!nav.pathPending && nav.remainingDistance < 1f) {
        	setNextWaypoint();
        }
    }
}
