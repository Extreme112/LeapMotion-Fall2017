using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Requirements for this script to work:
//Navemesh Agent
//Reference to Player gameobject (must be tagged as "Player")
//Animator and Animator controller
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
        anim.SetBool("idle0ToRun", true);
        anim.SetBool("runToIdle0", false);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            agent.isStopped = true;
            anim.SetBool("idle0ToRun", false);
            anim.SetBool("runToIdle0", true);

        }
    }
}
