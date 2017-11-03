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
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
