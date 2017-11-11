using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    int maxHealth = 100;
    int currentHealth;
    //SOUND
    public AudioClip hurtSound;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
        //Sound
        audioSource = GetComponent<AudioSource>();
	}

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        //Play sounds
        audioSource.clip = hurtSound;
        audioSource.Stop();
        audioSource.Play();
        if (currentHealth <= 0) {
            SceneManager.LoadScene("StartScreen"); //load start scene on death
        }
    }

    //Allows us to get the plyaers current health
    public int getHealth() {
        return currentHealth;
    }
}
