using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieMove : MonoBehaviour {
    NavMeshAgent agent;
    Animator anim;
    GameObject player;
	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>(); //use for animations
        player = GameObject.FindGameObjectWithTag("Player");
        agent.SetDestination(player.transform.position);

        //Transition to run animation for the zombie
        anim.SetBool("idle0ToRun", true);
        anim.SetBool("runToIdle0", false);
	}

    //To make this work, we need to add a Sphere Trigger to the Player
    private void OnTriggerEnter(Collider other) {
        //When we touch the player...
        if (other.CompareTag("Player")) {
            agent.isStopped = true;
            //Transition to idle animation from the run animation
            anim.SetBool("idle0ToRun", false);
            anim.SetBool("runToIdle0", true);
        }
    }
}
