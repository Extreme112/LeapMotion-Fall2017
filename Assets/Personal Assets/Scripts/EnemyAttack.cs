using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {
    public int damage;

    private void OnCollisionEnter(Collision collision) {
        GameObject go = collision.gameObject;
        if (go.CompareTag("Player")) {
            PlayerHealth pH = go.GetComponent<PlayerHealth>();
            pH.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
