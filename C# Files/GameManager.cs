using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Camera levelIntroCamera;
    public Camera gameplayCamera;

    public TextMeshProUGUI levelText;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI creditsText;

    private float levelStartTime;
    private float totalTimeTaken;
    private int currentLevel = 1;
    private int maxLevels = 2;
    private bool gameStarted = false;

    void Start()
    {
        StartLevel();
    }

    void Update()
    {
        if (gameStarted)
        {
            float elapsedTime = Time.time - levelStartTime;
            timerText.text = "Time: " + elapsedTime.ToString("F2") + "s";
        }
    }

    void StartLevel()
    {
        // Show level intro camera
        levelIntroCamera.gameObject.SetActive(true);
        gameplayCamera.gameObject.SetActive(false);

        levelText.gameObject.SetActive(true);
        timerText.gameObject.SetActive(false); // Hide timer initially

        levelText.text = "Level " + currentLevel;

        // Start game after 3 seconds
        Invoke("StartGame", 3f);
    }

    void StartGame()
    {
        // Switch to gameplay camera
        levelIntroCamera.gameObject.SetActive(false);
        gameplayCamera.gameObject.SetActive(true);

        levelText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(true);

        levelStartTime = Time.time;
        gameStarted = true;
    }

    public void CompleteLevel()
    {
        float levelTime = Time.time - levelStartTime;
        totalTimeTaken += levelTime;

        if (currentLevel < maxLevels)
        {
            currentLevel++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            ShowCredits();
        }
    }

    void ShowCredits()
    {
        levelText.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        creditsText.gameObject.SetActive(true);
        creditsText.text = "Game Completed!\nTotal Time: " + totalTimeTaken.ToString("F2") + "s";
    }
}

