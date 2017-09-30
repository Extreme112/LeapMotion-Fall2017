using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour {

    Vector3 direction;
    public float speed;
	// Use this for initialization
	void Start () {
        direction = HandDirectionGetter.getHandDirection("Right");
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed); //correct

        //transform.Translate(HandDirectionGetter.getHandDirection("Right") * speed); //wrong
    }

    //public void init(Vector3 direction, float speed) {
    //    this.direction = direction;
    //    this.speed = speed;
    //}
}
