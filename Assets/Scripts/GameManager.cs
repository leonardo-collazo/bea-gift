using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }
    public bool IsGameActive { get => isGameActive; }

    private int score;
    private bool isGameActive;

    [SerializeField] private int scoreToAdd;
    [SerializeField] private TMP_Text scoreText;

    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject hud;
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
        isGameActive = true;
        scoreText.text = score.ToString();
        gameOverPanel.SetActive(false);
        restartButton.onClick.RemoveAllListeners();
        restartButton.onClick.AddListener(RestartLevel);
    }

    // Add score
    public void AddScore()
    {
        score += scoreToAdd;
        UpdateScore();
    }

    // Update score
    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    // Start game over coroutine
    public void GameOver()
    {
        isGameActive = false;
        hud.SetActive(false);
        StartCoroutine(GameOverCoroutine());
    }

    // Shows the game over panel
    private IEnumerator GameOverCoroutine()
    {
        yield return new WaitForSeconds(1f);
        int currentHighScore = PlayerPrefs.GetInt("HighScore");

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }

        gameOverPanel.SetActive(true);

        currentScoreText.text = score.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Restart the game
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Change to next background if score is a multiple of 5
    public void ChangeBackground()
    {
        if (score % 5 == 0)
        {
            BackgroundControl_0.Instance.NextBG();
        }
    }

    // Pause the game
    public void PauseGame()
    {
        MusicManager.instance.StopMusic();
        pausePanel.SetActive(true);
        hud.SetActive(false);
        Time.timeScale = 0;
    }

    // Reanude the game
    public void ReanudeGame()
    {
        MusicManager.instance.PlayMusic();
        pausePanel.SetActive(false);
        hud.SetActive(true);
        Time.timeScale = 1;
    }

    // Exit game
    public void ExitGame()
    {
        Application.Quit();
    }
}
