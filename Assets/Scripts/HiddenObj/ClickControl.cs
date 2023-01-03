using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickControl : MonoBehaviour
{
    public static string nameobj;
    public Text objnametext;
    public GameObject Game;
    public GameObject Timer ;
    public GameObject Score;
    public GameObject Uparrows ;
    public GameObject Downarrows;
    public GameObject Rarrows;
    public GameObject Larrows;
    public GameObject Explain;

    public static int totalScore = 0;
    public static float timebonus = 90;
    public static int remaininItem = 6;

 
    public Transform objnametextPos;
    public Animator animator;

    public int randNumb = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Won()
    {
        SceneManager.LoadScene("WonHiddenObj");
    }

    // Update is called once per frame
    void Update()
    {
        nameobj = objnametext.text;
        if (HintMeter.hintused == "y")
        {
            randNumb = Random.Range(1, 7);
            if ((nameobj == "Dame") && (randNumb == 1))
            {
                animator.SetBool("IsOpen", true);
                HintMeter.hintused = "n";
            }
            if ((nameobj == "Roi") && (randNumb == 2))
            {
                animator.SetBool("IsOpen", true);
                HintMeter.hintused = "n";
            }
            if ((nameobj == "fou") && (randNumb == 3))
            {
                animator.SetBool("IsOpen", true);
                HintMeter.hintused = "n";
            }
            if ((nameobj == "cavalier") && (randNumb == 4))
            {
                animator.SetBool("IsOpen", true);
                HintMeter.hintused = "n";
            }
            if ((nameobj == "tour") && (randNumb == 5))
            {
                animator.SetBool("IsOpen", true);
                HintMeter.hintused = "n";
            }
            if ((nameobj == "pion") && (randNumb == 6))
            {
                animator.SetBool("IsOpen", true);
                HintMeter.hintused = "n";
            }

        }
        

    }

    void OnMouseDown ()
    {
        nameobj = objnametext.text ;
        Debug.Log(nameobj);
        Destroy( gameObject );
        
        remaininItem -= 1;
        

        //Destroy(GetComponent<BoxCollider>());
        objnametext.color = Color.red;
        Game.SetActive(false);
        Timer.SetActive(false);
        Score.SetActive(false);
        Uparrows.SetActive(false);
        Larrows.SetActive(false);
        Downarrows.SetActive(false);
        Rarrows.SetActive(false);
        Explain.SetActive(true);

        ClickTracking.totalclicks = 0;
        





    }

}
