using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager_T9 : MonoBehaviour
{
    bool isGameRunning = true;
    public float restartDelay = 3;

    public GameObject CompleteLevelUI;

    public void EndGame()
    {
        if (isGameRunning)
        {
            isGameRunning = false;
            Debug.Log("Game Over");
            Invoke("RestartGame", restartDelay);
        }
    }

    public void WinLevel()
    {
        Debug.Log("Won The Game");
        CompleteLevelUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
