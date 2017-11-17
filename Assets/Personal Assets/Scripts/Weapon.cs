using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public string wepName;
    public float delay;
    public GameObject bullet; //bullet prefab that a weapon will spawn
    private Coroutine fireRoutine; //Keeps track of the current coroutine

    public void StartFiring() {
        //calling this function will tell the weapon continously shoot every x seconds, where is the delay
        StopFiring();
        fireRoutine = StartCoroutine(FireRoutine());
    }

    public void StopFiring() {
        //calling this function will tell the weapon to stop shooting
        if (fireRoutine != null) {
            StopCoroutine(fireRoutine);
        }
    }

    //This coroutine will continously fire bullets every x seconds
    IEnumerator FireRoutine() {
        while (true) {
            Instantiate(bullet, HandDirectionGetter.GetPositionOfRightHand(), Quaternion.identity);
            yield return new WaitForSeconds(delay);
        }
    }
    
}
