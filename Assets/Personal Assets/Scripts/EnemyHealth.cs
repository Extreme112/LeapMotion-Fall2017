using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health;
    public int score;

    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            //add points to ScoreManager
            GameObject gm = GameObject.FindGameObjectWithTag("GameManager");
            ScoreManager sm = gm.GetComponent<ScoreManager>();
            sm.AddScore(score); //add score
            Destroy(this.gameObject);
        }
    }
}
