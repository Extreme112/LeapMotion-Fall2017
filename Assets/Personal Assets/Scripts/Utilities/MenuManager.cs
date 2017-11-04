using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene("GameScene");
    }

    //Quit the game
    public void QuitGame() {
        Application.Quit();
    }
}
