using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;
    Coroutine shootRoutine;
    public float shootDelay;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Q)) {
        //    Instantiate(bullet, HandDirectionGetter.GetPositionOfRightHand(), Quaternion.identity);
        //}
	}

    IEnumerator Shooting() {
        while (true) {
            Instantiate(bullet, HandDirectionGetter.GetPositionOfRightHand(), Quaternion.identity);
            yield return new WaitForSeconds(shootDelay);
        }
    }

    public void StartShooting() {
        shootRoutine = StartCoroutine(Shooting());
    }

    public void StopShooting() {
        if (shootRoutine != null) {
            StopCoroutine(shootRoutine);
        }
    }
}
