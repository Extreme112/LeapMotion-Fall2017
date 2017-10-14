using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {
    public int health;

    public void TakeDamage(int damage) {
        health -= damage;
        print(this.gameObject.name + ":" + health);
        if (health <= 0) {
            Destroy(gameObject);
        }
    }
}
