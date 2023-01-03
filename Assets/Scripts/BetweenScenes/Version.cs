using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Version : MonoBehaviour
{

    public void VA()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void VE()
    {
        SceneManager.LoadScene("MainMenu");
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
