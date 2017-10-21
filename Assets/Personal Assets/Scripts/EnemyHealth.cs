using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health;
    public int score;
    GameObject gm;
    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GameManager");
    }

    public void TakeDamage(int damage) {
        health -= damage;
        if (health <= 0) {
            //Add Score
            ScoreManager sm = gm.GetComponent<ScoreManager>();
            sm.AddScore(score);
            Destroy(this.gameObject);
        }
    }
}
