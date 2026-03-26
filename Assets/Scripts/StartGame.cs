using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject startUI;

    void Start()
    {
        Time.timeScale = 0f; // ❗ หยุดเกมก่อนเริ่ม
    }

    public void StartGamePlay()
    {
        Time.timeScale = 1f; // ▶ เริ่มเกม

        if (startUI != null)
        {
            startUI.SetActive(false); // ซ่อนปุ่ม
        }
    }
}