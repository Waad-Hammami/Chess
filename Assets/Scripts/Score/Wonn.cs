using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wonn : MonoBehaviour
{
   
    public float score = 0f;
    [SerializeField] Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Score()
    {
        if (score == 160)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
       
    }
}
