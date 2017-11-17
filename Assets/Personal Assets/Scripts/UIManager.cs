using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    //this stuff was for playerhealth
    public Slider healthSlider;
    GameObject player;
    PlayerHealth pH;

    //this stuff is for score
    public Text scoreText;
    ScoreManager sm;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        //through the playerHealth, we now have access to the players health
        pH = player.GetComponent<PlayerHealth>();

        //Score
        sm = GetComponent<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {
        //constantly updates the sliders value with the players current health
        healthSlider.value = pH.getHealth();
        scoreText.text = sm.getScore().ToString(); //continously update the score
	}
}
