using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour {
    public int health;
    public int score;
    GameObject gm;

    //Animations==========
    Animator anim; //allows us to trigger animations
    private float deathAnimLength; //length of death animation
    //====== END ============

    //"Die"ing cleanup
    ZombieAttack attackScript;

    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GameManager");

        //Animations=========
        anim = GetComponent<Animator>();
        //Get the legnth of the death animation clip
        AnimationClip[] clips = anim.runtimeAnimatorController.animationClips;
        foreach (AnimationClip aClip in clips) {
            if (aClip.name == "death") {
                deathAnimLength = aClip.length;
            }
        }
        //======== END ============

        //"Die"ing cleanup
        attackScript = GetComponent<ZombieAttack>();  
    }

    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            //Add Score
            ScoreManager sm = gm.GetComponent<ScoreManager>();
            sm.AddScore(score);
            //Destroy(this.gameObject);
            StartCoroutine(DieRoutine());       //Start the death code
        }
    }

    IEnumerator DieRoutine() {
        attackScript.enabled = false; //disable the attack script to prevent the enemy from attacking while the death 
        //animation is playing
        anim.SetTrigger("die"); //TODO: create this die trigger in the animator controller
        yield return new WaitForSeconds(deathAnimLength); //wait a few seconds...
        Destroy(this.gameObject); //before destroying the gameobject
    }
}
