using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{

    public void PlayGame()
    {
        Debug.Log("MainMenu: " + "Play [OK]");
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void QuitGame()
   {
      Debug.Log("MainMenu: " + "Quit [OK]");
      Application.Quit();
   }
   
}
