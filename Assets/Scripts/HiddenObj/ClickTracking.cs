using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickTracking : MonoBehaviour
{
    public static int totalclicks = 0;
    public KeyCode mouseclick;
    public Transform ScoreObj;
    

 
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClickControl.timebonus -= Time.deltaTime;
        
        //Track how much time passed
      
        if (ClickControl.remaininItem == 0)
        {
            ClickControl.totalScore += (60 + (Mathf.RoundToInt(ClickControl.timebonus)));
            ScoreObj.GetComponent<Text>().text = ClickControl.totalScore.ToString() ;
            ClickControl.remaininItem = -1;
            SceneManager.LoadScene("WonHiddenObj");



        }
        
        if (Input.GetKeyDown(mouseclick))
        {
            totalclicks += 1;

        }
        if (totalclicks >= 7)
        {
            Debug.Log("Fail");
            totalclicks = 0 ;

        }

    }
  
}
