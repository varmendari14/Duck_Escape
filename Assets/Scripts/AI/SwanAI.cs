using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class SwanAI : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent nav;
    Animator animator;
    AIState aIState;
    bool onTrack1 = true;

    public GameObject[] waypoints;
    public GameObject[] waypoints2;

    int currWaypoint = -1;

    float EPSILON = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        aIState = AIState.StationaryWaypoint;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
        setNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        switch (aIState)
        {
            case AIState.StationaryWaypoint:
                stationaryBehavior();
                break;
            default:
                break;
        }


    }

    private void setNextWaypoint()
    {
        if (waypoints.Length != 0)
        {
            currWaypoint = (currWaypoint + 1) % waypoints.Length;
            if (onTrack1)
            {
                nav.SetDestination(waypoints[currWaypoint].transform.position);
            }
            else
            {
                nav.SetDestination(waypoints2[currWaypoint].transform.position);
            }
        }
        else
        {
            Debug.LogError("Waypoints array must not be empty");
        }
    }

    private void stationaryBehavior()
    {
        if (System.Math.Abs(nav.remainingDistance) < EPSILON && nav.pathPending != true)
        {
            setNextWaypoint();
        }
        //animator.SetFloat("vely", nav.velocity.magnitude / nav.speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            onTrack1 = !onTrack1;
        }
    }
}
