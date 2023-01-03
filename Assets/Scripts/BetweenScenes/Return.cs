using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return : MonoBehaviour
{

    public void ReturnScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }

    public void ReturnToChoix ()
    {
        SceneManager.LoadScene("ChoisirPiece");
    }
    public void ReturnToNiveaux()
    {
        SceneManager.LoadScene("LesNiveaux");
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
