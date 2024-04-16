using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverUI;

    public static GameOverManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de GameOverManager dans la scène");
            return;
        }

        instance = this;
    }

    public void OnPlayerDeath()
    {
        gameOverUI.SetActive(true);
    }

    public void Restart()
    {
        Debug.Log("GameOverMenu: " + "Restart [OK]");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Home()
    {
        Debug.Log("GameOverMenu: " + "Home [OK]");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("GameOverMenu: " + "QuitGame [OK]");
        Application.Quit();
    }
}
