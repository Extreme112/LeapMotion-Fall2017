using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

    //Multiple Weapons
    public Weapon[] weapons;
    int selectedWeapon = 0;

    void Update () {
        if (Input.GetKeyDown(KeyCode.E)) {
            StopShooting(); //Stop the currently selected weapon from shooting before we switch weapons
            if (selectedWeapon == weapons.Length - 1) {
                selectedWeapon = 0;
            } else {
                selectedWeapon++;
            }
            print("Selected Weapon: " + weapons[selectedWeapon].wepName);
        }

        if (Input.GetKeyDown(KeyCode.Q)) {
            StopShooting(); //Stop the currently selected weapon from shooting before we switch weapons
            if (selectedWeapon == 0) {
                selectedWeapon = weapons.Length - 1;
            } else {
                selectedWeapon--;
            }
            print("Selected Weapon: " + weapons[selectedWeapon].wepName);
        }
	}

    public void StartShooting() {
        //Tell the selected weapon to START firing
        weapons[selectedWeapon].GetComponent<Weapon>().StartFiring();
    }

    public void StopShooting() {
        //Tell the selected weapon to STOP firing
        weapons[selectedWeapon].GetComponent<Weapon>().StopFiring();
    }
}
