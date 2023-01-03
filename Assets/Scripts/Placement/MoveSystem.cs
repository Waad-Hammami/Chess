using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveSystem : MonoBehaviour {
  
    
    public GameObject correctForm;
    private bool moving;

    private float startPosX;
    private float startPosY;




    void Update()
    {
        if (moving == true )
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.position = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.position.z);
        }
    }

    public void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        { 
          
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            startPosX = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;

            moving = true;


        }
    }

    public void OnMouseUp()
    {
        moving = false;
        if (Mathf.Abs(this.transform.position.x -correctForm.transform.position.x) < 0.5f  && Mathf.Abs(this.transform.position.y - correctForm.transform.position.y) < 0.5f )
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
        }
     /*else
        {
            this.transform.position = new Vector3(initialPosition.x, resetPosition.y, resetPosition.z);
        }
       */
    }


    // Update is called once per frame
  
}
