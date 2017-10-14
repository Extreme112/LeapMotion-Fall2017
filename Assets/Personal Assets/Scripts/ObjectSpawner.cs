using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject obj;
    public int count;
    public float delay;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnObjects());
	}

    IEnumerator SpawnObjects() {
        while (count > 0) {
            Instantiate(obj, transform.position, Quaternion.identity); //spawns an object
            count--; //count = count - 1
            yield return new WaitForSeconds(delay);
        }
        Destroy(this.gameObject); //destory the spawner
    }
}
