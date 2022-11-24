using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    private int score;
    [SerializeField] private int scoreToAdd;
    [SerializeField] private TMP_Text scoreText;
    
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private TMP_Text currentScoreText;
    [SerializeField] private TMP_Text highScoreText;
    [SerializeField] private Button restartButton;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
        gameOverPanel.SetActive(false);
        restartButton.onClick.RemoveAllListeners();
        restartButton.onClick.AddListener(RestartLevel);
    }

    public void AddScore()
    {
        score += scoreToAdd;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore");

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        gameOverPanel.SetActive(true);
        
        currentScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
