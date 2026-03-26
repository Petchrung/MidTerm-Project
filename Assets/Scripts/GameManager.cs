using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverUI;
    public GameObject restartButton;   // ⭐ เพิ่ม
    public GameObject startUI;
    public TextMeshProUGUI scoreText;

    private float timeSurvived = 0f;
    private bool isGameOver = false;
    private bool isGameStarted = false;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Time.timeScale = 0f;

        if (gameOverUI != null)
            gameOverUI.SetActive(false);

        if (restartButton != null)
            restartButton.SetActive(false);
    }

    void Update()
    {
        if (!isGameStarted || isGameOver) return;

        timeSurvived += Time.deltaTime;

        if (scoreText != null)
        {
            scoreText.text = "Time: " + timeSurvived.ToString("F1");
        }
    }

    public void StartGame()
    {
        isGameStarted = true;

        if (startUI != null)
        {
            startUI.SetActive(false);
        }

        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        if (restartButton != null)
        {
            restartButton.SetActive(true);   // ⭐ สั่งให้ปุ่มโผล่
        }

        Time.timeScale = 0f;
    }
}