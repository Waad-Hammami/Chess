using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject Game;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {   
              
                Resume();
               
                
            }
            else
            {
                Game.SetActive(false);
                Pause();
               
            }
        }
    }

  
    public void Resume()
    {
        Game.SetActive(true);
   
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Game.SetActive(false);    
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        Debug.Log("Loading Menu ...");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game ...");
        Application.Quit();
    }

    


}