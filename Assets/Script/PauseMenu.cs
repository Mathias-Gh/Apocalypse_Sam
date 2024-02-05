using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject settingsMenu;

    public bool activeEscape = false;
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Debug.Log("PauseMenu: " + "Escape [IsPressed]");
            if (!activeEscape)
            {
                
                pauseMenu.SetActive(true);
                activeEscape = true;
            }
            else
            {
                pauseMenu.SetActive(false);
                settingsMenu.SetActive(false);
                activeEscape = false;
            }
        }
    }
    public void Home()
    {
        Debug.Log("PauseMenu: " + "Home [OK]");
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        Debug.Log("PauseMenu: " + "Pause [OK]");
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {   
        Debug.Log("PauseMenu: " + "Resume [OK]");
        pauseMenu.SetActive(false);
        activeEscape = false;
    }

    public void Restart()
    {
        Debug.Log("PauseMenu: " + "Restart [OK]");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Parameters()
    {
        Debug.Log("PauseMenu: " + "Parameters [OK]");
        settingsMenu.SetActive(true);
    }

    public void QuitGame()
   {
    Debug.Log("PauseMenu: " + "QuitGame [OK]");
    Application.Quit();
   }
}