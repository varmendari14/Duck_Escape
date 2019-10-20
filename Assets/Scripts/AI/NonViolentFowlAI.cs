using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class NonViolentFowlAI : MonoBehaviour
{
    /*UnityEngine.AI.NavMeshAgent nav;
    Animator animator;
    AIState aIState;
    bool onTrack1 = true;

    public GameObject[] waypoints;
    public GameObject[] waypoints2;
    public float visibilityConeAngle = 20;
    public float visibleDist = 10;
    public float evadeDistanceMin = 2;
    public float evadeDistanceMax = 8;
    public float navMeshMaxDist = 5;
    public GameObject hitLoc;
    public GameObject runToCube;

    int currWaypoint = -1;

    GameObject player;

    float EPSILON = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        aIState = AIState.Wander;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
        setNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        switch (aIState)
        {
            case AIState.Wander:
                WanderBehavior();
                break;
            case AIState.Evade:
                EvadeBehavior();
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

    private void WanderBehavior()
    {
        if (System.Math.Abs(nav.remainingDistance) < EPSILON && nav.pathPending != true)
        {
            setNextWaypoint();
        }
        //animator.SetFloat("vely", nav.velocity.magnitude / nav.speed);
    }

    private void EvadeBehavior()
    {
        if ((player.transform.position - transform.position).magnitude > visibleDist)
        {
            aIState = AIState.Wander;
            setNextWaypoint();
        }
        else
        {
            // evade the player
            // TODO: fix issue where the duck is unable to hop the small divider
            // TODO: fix duck animation
            // TODO: refine visibility parameters
            Debug.Log("Evading");
            transform.rotation = Quaternion.LookRotation(transform.position - player.transform.position);

            Vector3 runTo = transform.position + transform.forward * Random.Range(evadeDistanceMin, evadeDistanceMax);
            runToCube.transform.position = runTo;
            Debug.Log(runTo.ToString());

            UnityEngine.AI.NavMeshHit hit;
            UnityEngine.AI.NavMesh.SamplePosition(runTo, out hit, navMeshMaxDist, UnityEngine.AI.NavMesh.AllAreas);
            if (!nav.pathPending) { }
            nav.SetDestination(hit.position);
            hitLoc.transform.position = hit.position;
        }
    }

    private void JumpBehavior()
    {
        //implement behavior to randomly jump while wandering
    }

    private void StopBehavior()
    {
        //implement behavior to randomly stop while wandering
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player = other.gameObject;
            Vector3 duckToEnemy = other.gameObject.transform.position - transform.position;
            Vector3 duckDir = transform.forward;
            float viewAngle = Vector3.Angle(duckToEnemy, duckDir);
            if (viewAngle < visibilityConeAngle && duckToEnemy.magnitude < visibleDist)
            {
                aIState = AIState.Evade;
            }
            onTrack1 = !onTrack1;
        }
    }*/
}
