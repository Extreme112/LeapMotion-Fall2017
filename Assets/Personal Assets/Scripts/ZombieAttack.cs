using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour {
    public float attackDelay; //# of seconds in between zombie attacks
    public int damage; //damage of the Zombie
    private bool canAttack = true;

    //Animations
    Animator anim;
    //Sounds Effects
    public AudioClip attackSound; //this is the sound; specified in the unity editor
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        //Sound
        audioSource = GetComponent<AudioSource>();
	}

    private void OnTriggerStay(Collider other) {
        GameObject hit = other.gameObject;
        if (hit.CompareTag("Player") && canAttack == true) { //check for two conditions now
            //Play attack sound. MAKE SURE YOU HAVE AUDIOSOURCE COMPONENT IN ZOMBIE GAMEOBJECT
            audioSource.clip = attackSound;
            audioSource.Stop();
            audioSource.Play();
            //Deal damage to the Player
            hit.GetComponent<PlayerHealth>().TakeDamage(damage); //deal damage to player
            //Play animation
            anim.SetTrigger("attack1");
            StartCoroutine(AttackDelay());
        }
    }
    //So we dont attack multiple times a seconds
    IEnumerator AttackDelay() {
        canAttack = false;
        yield return new WaitForSeconds(attackDelay); //wait a bit
        canAttack = true;
    }
}
