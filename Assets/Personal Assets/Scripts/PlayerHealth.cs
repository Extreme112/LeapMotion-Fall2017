using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    int maxHealth = 100;
    int currentHealth;

	// Use this for initialization
	void Start () {
        currentHealth = maxHealth;
	}

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        if (currentHealth <= 0) {
            SceneManager.LoadScene("StartScreen"); //load start scene on death
        }
    }
}
