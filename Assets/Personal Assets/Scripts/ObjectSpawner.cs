using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {
<<<<<<< InClassWork

=======
>>>>>>> End of Class 5
    public GameObject obj;
    public int count;
    public float delay;

<<<<<<< InClassWork
	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnObjects());
	}
=======
    // Use this for initialization
    void Start() {
        StartCoroutine(SpawnObjects());
    }
>>>>>>> End of Class 5

    IEnumerator SpawnObjects() {
        while (count > 0) {
            Instantiate(obj, transform.position, Quaternion.identity); //spawns an object
            count--; //count = count - 1
            yield return new WaitForSeconds(delay);
        }
        Destroy(this.gameObject); //destory the spawner
    }
}
