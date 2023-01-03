using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CountDownTimer : MonoBehaviour {

	float currentTime = 0f;
	float startingTime = 60f ;

	[SerializeField] Text countDownText;


	// Use this for initialization
	void Start () {
		
		currentTime = startingTime;
		
	}
	
	// Update is called once per frame
	void Update () {
		
		currentTime -= 1 * Time.deltaTime ;
		countDownText.text = currentTime.ToString("0") ;
		
		if(currentTime <= 15.0f)
		{
			countDownText.color = Color.red;
		}

		if (currentTime <= 0 )
		{
			currentTime = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
		
	}
}
