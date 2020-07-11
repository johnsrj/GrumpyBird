using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject highScoreIndicator;

    private void Start(){
        Time.timeScale = 1;
        //gameOverCanvas.SetActive(false);
    }

    public void GameOver(){
        gameOverCanvas.SetActive(true);
        if (Score.hi < Score.score){
            Score.hi = Score.score;
            highScoreIndicator.SetActive(true);
            PlayerPrefs.SetInt("highscore", Score.hi);
        }
        //Debug.Log(Score.hi);
        Time.timeScale = 0;
    }

    public void Replay(){
        SceneManager.LoadScene(1);  
    }
}
