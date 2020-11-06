using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform goal;      // where we going   
    private NavMeshAgent agent; // this navmesh character

    void Start()
    {
        goal = FindObjectOfType<PlayerHealthEnergy>().transform;    // look for the player
        GetComponent<Rigidbody>().isKinematic = true;               // set them to kinematic for rigidbody
        agent = GetComponent<NavMeshAgent>();                       // rename navmesh
        agent.updateRotation = false;
    }

    void Update()
    {
        if(agent.enabled) // if the navMesh is active then go to the target
        {
            agent.destination = goal.position;
        }

        if(Vector3.Distance(this.transform.position, goal.position) >= 5) // force restart incase the collision doesn't detect it
        {
            agent.enabled = true;
        }
    }

    void OnCollisionEnter(Collision collision) // when we collide with the player
    {
        agent.enabled = false;
        GetComponent<Rigidbody>().isKinematic = false;
    }

    private void OnCollisionExit(Collision collision) // when the player leaves
    {
        agent.enabled = true;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
