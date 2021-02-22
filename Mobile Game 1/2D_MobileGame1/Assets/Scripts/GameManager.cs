using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI gameOverText;
    public GameObject GOPanel;
    public GameObject LevelFinish;
    //public TextMeshProUGUI finishedLevelText;
    public Button restartButton;
    public Button nextLevel;
    public bool isGameActive;
    public bool levelFinished;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        levelFinished = false;
        score = 0;
        UpdateScore(0);
        GOPanel.SetActive(false);
        //LevelFinish.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER");
        restartButton.gameObject.SetActive(true);
        GOPanel.SetActive(true);

        //gameOverText.gameObject.SetActive(true);
        //isGameActive = false;

    }
    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

    public void LevelFinishhh()
    {
        LevelFinish.SetActive(true);
        nextLevel.gameObject.SetActive(true);
    }

    public void LevelFinished()
    {
        SceneManager.LoadScene(2);
        // nextLevel.gameObject.SetActive(true);
        isGameActive = false;
        levelFinished = true;
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
