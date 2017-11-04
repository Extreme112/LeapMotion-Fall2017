using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //This is for UI
using UnityEngine.SceneManagement; //For switching scenes

//Load next level when time expires
public class WinTimer : MonoBehaviour {

    public int time; //how long player has to survive for
    public Text winTimerText;
    public string sceneToLoad;

    public void StartTimer() {
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown() {
        while (time > 0) {
            yield return new WaitForSeconds(1);
            time--;
            winTimerText.text = time.ToString();
        }
        SceneManager.LoadScene(sceneToLoad);
    }
}
