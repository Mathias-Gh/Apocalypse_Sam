using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    public bool activeEscape = false;
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (!activeEscape)
            {
                pauseMenu.SetActive(true);
                activeEscape = true;
            }
            else
            {
                pauseMenu.SetActive(false);
                activeEscape = false;
            }
        }
    }
    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        activeEscape = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}