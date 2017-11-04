using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Requirements for this script to work:
//Add a trigger to the Player
//Player gameobject must have a PlayerHealth component with a public TakeDage() funciton
//Player must be tagged as "Player"
//Zombie must have Animator && AnimatorController
public class ZombieAttack : MonoBehaviour {

    public float attackDelay;
    public int damage;
    private bool canAttack = true;
    //Sounds
    public AudioClip attackSound;
    private AudioSource audioSource;
    //Animations
    private Animator anim;

    private void Start() {
        audioSource = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) {
        print(other.gameObject.name);
    }

    private void OnTriggerStay(Collider collision) {
        print(collision.gameObject.name);
        GameObject hit = collision.gameObject;

        if (hit.CompareTag("Player") && canAttack) {
            print("attacking player");

            //Play sound
            audioSource.clip = attackSound;
            audioSource.Stop();
            audioSource.Play();
            //Trigger animation
            anim.SetTrigger("attack1");
            //deal damage
            hit.GetComponent<PlayerHealth>().TakeDamage(damage);
            canAttack = false;
            StartCoroutine(AttackDelay());
        }
    }

    IEnumerator AttackDelay() {
        yield return new WaitForSeconds(attackDelay);
        canAttack = true;
    }
}
