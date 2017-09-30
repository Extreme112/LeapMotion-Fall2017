using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    
        if (Input.GetKeyDown(KeyCode.Q)) {
            Instantiate(bullet, HandDirectionGetter.GetPositionOfRightHand(), Quaternion.identity);
        }

	}
}
