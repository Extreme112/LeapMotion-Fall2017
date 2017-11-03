using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//The time before enemies start spawning
public class StartCountdown : MonoBehaviour {
    public int countdown;
    public Text countdownText; //where we will display our countdown

    public GameObject spawner; //disable spawners on awake
    private Coroutine timerRoutine;

    public WinTimer wintimer; //WIN timer
    // Use this for initialization
	void Awake () {
        spawner.SetActive(false);
	}

    void Start() {
        StartCoroutine(TimerRoutine()); //this will start the countdown
    }
    //This will set the spawners active after a certain amount of time
    IEnumerator TimerRoutine() {
        while (countdown > 0) {
            yield return new WaitForSeconds(1);
            countdown--;
            countdownText.text = countdown.ToString();
        }
        //Countdown ends here
        wintimer.StartTimer(); //Start the win Timer
        spawner.SetActive(true);
        Destroy(countdownText.gameObject);
    }
}
