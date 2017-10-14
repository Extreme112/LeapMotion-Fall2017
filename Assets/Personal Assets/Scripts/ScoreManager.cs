using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    int currentScore = 0;

    public void AddScore(int score) {
        currentScore += score;
        print(currentScore);
    }

    public int getScore() {
        return currentScore;
    }
}
