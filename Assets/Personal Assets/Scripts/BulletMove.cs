using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    Vector3 direction;
    public float speed;
    public int damage;
	// Use this for initialization
	void Start () {
        direction = HandDirectionGetter.getHandDirection("Right");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed); //correct
    }

    private void OnCollisionEnter(Collision collision) {
        GameObject hitObject = collision.gameObject;
        if (hitObject.CompareTag("Enemy")) {
            //deal damage
            EnemyHealth eh = hitObject.GetComponent<EnemyHealth>();
            eh.TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
