using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;
    public float shootDelay;
    Coroutine shootRoutine;

    public void StartShooting() {
        shootRoutine = StartCoroutine(StartShootingRoutine());
    }

    public void StopShooting() {
        if (shootRoutine != null) {
            StopCoroutine(shootRoutine);
        }
    }

    IEnumerator StartShootingRoutine() {
        while (true) {
            yield return new WaitForSeconds(shootDelay);
            Instantiate(bullet, HandDirectionGetter.GetPositionOfRightHand(), Quaternion.identity);
        }
    }
}
