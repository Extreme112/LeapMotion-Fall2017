using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    Vector3 direction;
    public float speed;
    public int damage;
	// Use this for initialization
	void Start () {
        direction = HandDirectionGetter.getHandDirection("Right");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed * Time.deltaTime); //correct
    }

    private void OnCollisionEnter(Collision collision) {
        GameObject hitObject = collision.transform.gameObject;
        if (hitObject.CompareTag("Enemy")) {
            EnemyHealth enemyHealth = hitObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }

}
