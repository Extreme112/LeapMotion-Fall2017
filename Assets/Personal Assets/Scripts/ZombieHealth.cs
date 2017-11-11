using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour {
    public int health;
    public int score;
    GameObject gm;
    ZombieAttack zombieAttack;
    //Animation
    Animator anim;
    private float deathAnimLength;

    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GameManager");
        zombieAttack = GetComponent<ZombieAttack>();
        anim = GetComponent<Animator>();

        //Find the death animations clip length
        AnimationClip[] clips = anim.runtimeAnimatorController.animationClips;
        foreach (AnimationClip aClip in clips) {
            if (aClip.name == "death") {
                deathAnimLength = aClip.length;
            }
        }
    }

    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            //Add Score
            ScoreManager sm = gm.GetComponent<ScoreManager>();
            sm.AddScore(score);
            StartCoroutine(Die());
        }
    }

    IEnumerator Die() {
        //Disable the Zombie Attack Script so the zombie stops attacking us
        zombieAttack.enabled = false;
        //Play animation
        anim.SetTrigger("die"); //Create this trigger in the Animator Controller of the Zombie
        //Wait a bit while the animation is playing
        yield return new WaitForSeconds(deathAnimLength);
        //Then die
        Destroy(this.gameObject); //Destroys the gameobject this script is attatched to
    }
}
