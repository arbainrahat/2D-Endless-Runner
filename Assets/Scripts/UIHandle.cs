using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHandle : MonoBehaviour
{
    public static UIHandle inst;

    public GameObject pausePanel, failedPanel;

    private void Awake()
    {
        inst = this;
    }

    public void OnClick_PauseBtn()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void OnClick_ResumeBtn()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void OnClick_RestartBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void OnClick_HomeBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnLevelFailed()
    {
        Time.timeScale = 0;
        failedPanel.SetActive(true);
    }
}
