using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WonHiddenObj : MonoBehaviour
{
    public Animator animator;
    public  void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
   public void Rejouer()
    {
        SceneManager.LoadScene("HiddenObj");
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game ...");
        Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
