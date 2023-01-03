using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Close : MonoBehaviour
{
    public GameObject Explain;
    public GameObject Game;
    public GameObject Timer;
    public GameObject Uparrows;
    public GameObject Downarrows;
    public GameObject Rarrows;
    public GameObject Larrows;
    public GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void fermer()
    {
        Game.SetActive(true);
        Timer.SetActive(true);
        Uparrows.SetActive(true);
        Larrows.SetActive(true);
        Downarrows.SetActive(true);
        Rarrows.SetActive(true);
        Score.SetActive(true);
        Explain.SetActive(false);
    }

}


