using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuHiddenObj : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject Game;
    public GameObject Timer;
    public GameObject Score;
    public GameObject Uparrows;
    public GameObject Downarrows;
    public GameObject Rarrows;
    public GameObject Larrows;




    [System.Obsolete]
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
                Timer.SetActive(false);
                Score.SetActive(false);
                Uparrows.SetActive(false);
                Larrows.SetActive(false);
                Downarrows.SetActive(false);
                Rarrows.SetActive(false);
                Pause();

            }
        }
    }


    public void Resume()
    {
        Game.SetActive(true);
        Timer.SetActive(true);
        Score.SetActive(true);
        Uparrows.SetActive(true);
        Larrows.SetActive(true);
        Downarrows.SetActive(true);
        Rarrows.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Game.SetActive(false);
        Timer.SetActive(false);
        Score.SetActive(false);
        Uparrows.SetActive(false);
        Larrows.SetActive(false);
        Downarrows.SetActive(false);
        Rarrows.SetActive(false);
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
