using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //allows us to switch/reload scenes

public class PlayerHealth : MonoBehaviour {
    int maxHealth = 100;
    int currentHealth;
	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}

    public void TakeDamage(int dmg) {
        currentHealth -= dmg; //currentHealth = currentHealth - dmg;
        if (currentHealth <= 0) {
            //Death handling code
            //play a death sound, play a death animation, subract lives
            SceneManager.LoadScene("StartScreen"); //eventually go back to start screen
        }
    }

    //Allows us to get the plyaers current health
    public int getHealth() {
        return currentHealth;
    }
}
