using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    public string wepName;
    public float delay;
    public GameObject bullet;
    private Coroutine fireRoutine;

    public void StartFiring() {
        StopFiring();
        fireRoutine = StartCoroutine(Fire());
    }

    public void StopFiring() {
        if (fireRoutine != null) {
            StopCoroutine(fireRoutine);
        }
    }

    IEnumerator Fire() {
        while (true) {
            Instantiate(bullet, HandDirectionGetter.GetPositionOfRightHand(), Quaternion.identity);
            yield return new WaitForSeconds(delay);
        }
    }
}
