using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverUI;
    public GameObject startUI; // ⭐ เพิ่ม
    public TextMeshProUGUI scoreText;

    private float timeSurvived = 0f;
    private bool isGameOver = false;
    private bool isGameStarted = false; // ⭐ เพิ่ม

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Time.timeScale = 0f; // ⭐ หยุดเกมตอนเริ่ม
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

    public void StartGame() // ⭐ ปุ่ม START จะเรียกอันนี้
    {
        isGameStarted = true;

        if (startUI != null)
        {
            startUI.SetActive(false); // ซ่อน UI
        }

        Time.timeScale = 1f; // เริ่มเวลา
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;

        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
        }

        Time.timeScale = 0f;
    }
}