using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    bool gameHasEnded = false;
    float delay = 1f;
    public GameObject gameObjectUI;

    public void CompleteLevel()
    {
        gameObjectUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", delay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
