using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAI : NonViolentFowlAI
{
     UnityEngine.AI.NavMeshAgent mesh;
     Rigidbody rig;
    Animator anim;
    public GameObject[] waypoints = new GameObject[4];
    int currWaypoint = 0;
    UnityEngine.AI.NavMeshAgent nav;
    Vector3 dir;
    float dot;
    public GameObject collider;
    FowlRun fowl;
    public GameObject player;
    Vector3 relativePos;
    float counter = 3;


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
        fowl = collider.GetComponent<FowlRun>(); 
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        rig = GetComponent<Rigidbody>();
        setNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (fowl.trig == true) {
            Debug.Log("run away" + player.transform.position);
                Vector3 heading = this.transform.position - player.transform.position;
                nav.SetDestination(player.transform.position + heading * 5);
                nav.speed = 4f;
                counter -= Time.deltaTime;

                if (counter < 0) {
                nav.isStopped = true;
                nav.ResetPath(); 
                nav.speed = 1.5f;
                fowl.trig = false;
                counter = 3;
                }
            } else {
                if (!nav.pathPending && nav.remainingDistance < 1f) {
                setNextWaypoint();
                }
            }
    }
}
