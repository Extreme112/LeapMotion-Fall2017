﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
<<<<<<< HEAD
<<<<<<< InClassWork

=======
>>>>>>> End of Class 5
=======
>>>>>>> catchUp
    public GameObject obj;
    public int count;
    public float delay;

<<<<<<< HEAD
<<<<<<< InClassWork
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnObjects());
	}
=======
=======
>>>>>>> catchUp
    // Use this for initialization
    void Start() {
        StartCoroutine(SpawnObjects());
    }
<<<<<<< HEAD
>>>>>>> End of Class 5
=======
>>>>>>> catchUp

    IEnumerator SpawnObjects() {
        while (count > 0) {
            Instantiate(obj, transform.position, Quaternion.identity); //spawns an object
            count--; //count = count - 1
            yield return new WaitForSeconds(delay);
        }
        Destroy(this.gameObject); //destory the spawner
    }
}
